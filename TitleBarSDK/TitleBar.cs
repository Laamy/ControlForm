namespace testform.TitleBarSDK;

using System.Drawing;
using System.Windows.Forms;

using Microsoft.Win32;

public class TitleBar
{
    public static void SetMovable(ControlForm form, Panel control)
    {
        bool dragging = false;
        Point offset = new Point();

        control.MouseDown += (sender, e) =>
        {
            dragging = true;
            offset = e.Location;
        };

        control.MouseMove += (sender, e) =>
        {
            if (dragging)
            {
                Point currentScreenPos = form.PointToScreen(e.Location);
                form.Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        };

        control.MouseUp += (sender, e) =>
        {
            dragging = false;
        };
    }
    public static Color fromABGR(int abgr)
    {
        int a = (abgr >> 24) & 0xFF;
        int b = (abgr >> 16) & 0xFF;
        int g = (abgr >> 8) & 0xFF;
        int r = abgr & 0xFF;
        return Color.FromArgb(a, r, g, b);
    }
    public static Color GetAccentColor()
    {
        var key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\DWM");
        int colorValue = (int)key?.GetValue("AccentColor", 0);
        return fromABGR(colorValue);
    }
}
