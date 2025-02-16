using testform.TitleBarSDK;

using System.Drawing;
using System;
using System.Windows.Forms;

namespace testform;

public partial class OverlapForm : ControlForm
{
    public Color AdjustedForeColor()
    {
        Color colorCalc = TitleBarPanel.BackColor;

        // check if dark or light color
        int r = colorCalc.R;
        int g = colorCalc.G;
        int b = colorCalc.B;
        double luminance = (0.299 * r + 0.587 * g + 0.114 * b) / 255;

        return luminance > 0.5 ? Color.Black : SystemColors.Control;
    }

    public OverlapForm()
    {
        InitializeComponent();

        //var winForm = new Form();
        //winForm.Text = "Form1";
        //winForm.Show();

        this.Text = "Form1";

        DoubleBuffered = true;

        TitleBar.SetMovable(this, TitleBarPanel);
        TitleBar.SetMovable(this, panel3);

        // animations n code for titlebar btns
        {
            Titlebar_MinBtn.Click += (s, e) => WindowState = FormWindowState.Minimized;
            Titlebar_XBtn.Click += (s, e) => Close();//Application.Exit();
            Titlebar_MinMaxBtn.Click += (s, e) =>
            {
                WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
                Titlebar_MinMaxBtn.Text = WindowState == FormWindowState.Maximized ? "" : "";
            };

            // some animations for the titlebar btns
            void TitlebarBtn_MouseEnter(object sender, EventArgs e)
            {
                var btn = sender as Label;
                btn.ForeColor = Color.Gray;

                var t = TitleBarPanel.BackColor;
                btn.BackColor = Color.FromArgb(t.R + 15, t.G + 15, t.B + 15);
            }

            void TitlebarBtn_MouseLeave(object sender, EventArgs e)
            {
                var btn = sender as Label;
                btn.ForeColor = AdjustedForeColor();
                btn.BackColor = TitleBarPanel.BackColor;
            }

            TitleBarPanel.BackColor = panel2.BackColor;

            Titlebar_MinBtn.MouseEnter += TitlebarBtn_MouseEnter;
            Titlebar_MinBtn.MouseLeave += TitlebarBtn_MouseLeave;
            Titlebar_MinMaxBtn.MouseEnter += TitlebarBtn_MouseEnter;
            Titlebar_MinMaxBtn.MouseLeave += TitlebarBtn_MouseLeave;
            Titlebar_XBtn.MouseEnter += TitlebarBtn_MouseEnter;
            Titlebar_XBtn.MouseLeave += TitlebarBtn_MouseLeave;

            void FixTitlebarBtns()
            {
                Titlebar_MinBtn.ForeColor = AdjustedForeColor();
                Titlebar_MinBtn.BackColor = TitleBarPanel.BackColor;

                Titlebar_MinMaxBtn.ForeColor = AdjustedForeColor();
                Titlebar_MinMaxBtn.BackColor = TitleBarPanel.BackColor;

                Titlebar_XBtn.ForeColor = AdjustedForeColor();
                Titlebar_XBtn.BackColor = TitleBarPanel.BackColor;

            }

            Activated += (s, e) =>
            {
                FixTitlebarBtns();

                Invalidate();
            };

            Deactivate += (s, e) =>
            {
                FixTitlebarBtns();

                Invalidate();
            };
        }
    }
}
