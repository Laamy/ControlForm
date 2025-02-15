
using System.Drawing;
using System;
using System.Windows.Forms;

using testform.TitleBarSDK;

namespace testform;

public partial class Form1 : ControlForm
{
    public Form1()
    {
        InitializeComponent();

        TitleBar.SetMovable(this, TitleBarPanel);

        // animations n code for titlebar btns
        {
            Titlebar_MinBtn.Click += (s, e) => WindowState = FormWindowState.Minimized;
            Titlebar_MinMaxBtn.Click += (s, e) => WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
            Titlebar_XBtn.Click += (s, e) => Application.Exit();

            // some animations for the titlebar btns
            Titlebar_MinBtn.MouseEnter += TitlebarBtn_MouseEnter;
            Titlebar_MinBtn.MouseLeave += TitlebarBtn_MouseLeave;
            Titlebar_MinMaxBtn.MouseEnter += TitlebarBtn_MouseEnter;
            Titlebar_MinMaxBtn.MouseLeave += TitlebarBtn_MouseLeave;
            Titlebar_XBtn.MouseEnter += TitlebarBtn_MouseEnter;
            Titlebar_XBtn.MouseLeave += TitlebarBtn_MouseLeave;
        }
    }

    // hover
    public void TitlebarBtn_MouseEnter(object sender, EventArgs e)
    {
        var btn = (Label)sender;
        btn.ForeColor = Color.Gray;

        var t = TitleBarPanel.BackColor;
        btn.BackColor = Color.FromArgb(t.R + 15, t.G + 15, t.B + 15);
    }

    // leave
    public void TitlebarBtn_MouseLeave(object sender, EventArgs e)
    {
        var btn = (Label)sender;
        btn.ForeColor = Color.FromArgb(255, 255, 255);
        btn.BackColor = TitleBarPanel.BackColor;
    }
}
