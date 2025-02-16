
namespace testform.TitleBarSDK;

using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

public class ControlForm : Form
{
    protected override void OnHandleCreated(EventArgs e)
    {
        DisableCaption();
        base.OnHandleCreated(e);
    }

    protected override void OnSizeChanged(EventArgs e)
    {
        DisableCaption();
        base.OnSizeChanged(e);
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int Left, Top, Right, Bottom;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NCCALCSIZE_PARAMS
    {
        public RECT rgrc;
        public IntPtr lppos;
    }

    [DllImport("user32.dll", SetLastError = true)]
    public static extern IntPtr GetWindowLong(IntPtr hWnd, int nIndex);

    [DllImport("user32.dll")]
    public static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

    [DllImport("user32.dll")]
    public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

    void DisableCaption()
    {
        if (DesignMode) return;

        // reisze redraw cuz flicker shit
        DoubleBuffered = true;
        ResizeRedraw = true;

        // border removal
        IntPtr style = GetWindowLong(this.Handle, -16);
        style = (IntPtr)((int)style & ~(0x00C00000));
        SetWindowLong(this.Handle, -16, style);

        // update window properly
        SetWindowPos(this.Handle, IntPtr.Zero, 0, 0, 0, 0, 0x0002 | 0x0001 | 0x0020);
    }

    void EnableCaption() => FormBorderStyle = FormBorderStyle.Sizable;

    // remove border again while maintaining windows functionality like aero, rounded, ect
    protected override void OnGotFocus(EventArgs e) => DisableCaption();

    // I have no fucking clue why this works (i've been writing this for the past 1h and 43 minutes)
    protected override void OnLostFocus(EventArgs e) => EnableCaption();

    protected override void WndProc(ref Message m)
    {
        if (m.Msg == 0x0083)
        {
            if (DesignMode) // vs fucking SUCKS
            {
                base.WndProc(ref m);
                return;
            }

            NCCALCSIZE_PARAMS ncsp = (NCCALCSIZE_PARAMS)Marshal.PtrToStructure(m.LParam, typeof(NCCALCSIZE_PARAMS));
            ncsp.rgrc = new RECT { Left = ncsp.rgrc.Left + 5, Top = ncsp.rgrc.Top + 1, Right = ncsp.rgrc.Right - 5, Bottom = ncsp.rgrc.Bottom - 5 };
            Marshal.StructureToPtr(ncsp, m.LParam, false);
            m.Result = IntPtr.Zero;
            return;
        }

        base.WndProc(ref m);
    }
}
