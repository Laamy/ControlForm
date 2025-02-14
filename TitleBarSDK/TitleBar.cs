using System.Drawing;
using System.Windows.Forms;

namespace testform.TitleBarSDK
{
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
    }
}
