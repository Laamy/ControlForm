using testform.TitleBarSDK;

namespace testform
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleBarPanel = new System.Windows.Forms.Panel();
            this.TitleBar_IconPct = new System.Windows.Forms.PictureBox();
            this.TitleBar_TitleLbl = new System.Windows.Forms.Label();
            this.Titlebar_MinBtn = new testform.TitleBarSDK.ControlLabel();
            this.Titlebar_MinMaxBtn = new testform.TitleBarSDK.ControlLabel();
            this.Titlebar_XBtn = new testform.TitleBarSDK.ControlLabel();
            this.TitleBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBar_IconPct)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.BackColor = System.Drawing.SystemColors.Control;
            this.TitleBarPanel.Controls.Add(this.TitleBar_IconPct);
            this.TitleBarPanel.Controls.Add(this.TitleBar_TitleLbl);
            this.TitleBarPanel.Controls.Add(this.Titlebar_MinBtn);
            this.TitleBarPanel.Controls.Add(this.Titlebar_MinMaxBtn);
            this.TitleBarPanel.Controls.Add(this.Titlebar_XBtn);
            this.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleBarPanel.Name = "TitleBarPanel";
            this.TitleBarPanel.Size = new System.Drawing.Size(251, 30);
            this.TitleBarPanel.TabIndex = 0;
            // 
            // TitleBar_IconPct
            // 
            this.TitleBar_IconPct.BackColor = System.Drawing.Color.Transparent;
            this.TitleBar_IconPct.Location = new System.Drawing.Point(8, 7);
            this.TitleBar_IconPct.Name = "TitleBar_IconPct";
            this.TitleBar_IconPct.Size = new System.Drawing.Size(16, 16);
            this.TitleBar_IconPct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TitleBar_IconPct.TabIndex = 4;
            this.TitleBar_IconPct.TabStop = false;
            // 
            // TitleBar_TitleLbl
            // 
            this.TitleBar_TitleLbl.AutoSize = true;
            this.TitleBar_TitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.TitleBar_TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBar_TitleLbl.ForeColor = System.Drawing.Color.LightGray;
            this.TitleBar_TitleLbl.Location = new System.Drawing.Point(26, 7);
            this.TitleBar_TitleLbl.Name = "TitleBar_TitleLbl";
            this.TitleBar_TitleLbl.Size = new System.Drawing.Size(75, 15);
            this.TitleBar_TitleLbl.TabIndex = 3;
            this.TitleBar_TitleLbl.Text = "ControlForm";
            // 
            // Titlebar_MinBtn
            // 
            this.Titlebar_MinBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Titlebar_MinBtn.Font = new System.Drawing.Font("Segoe Fluent Icons", 7F);
            this.Titlebar_MinBtn.ForeColor = System.Drawing.Color.White;
            this.Titlebar_MinBtn.Location = new System.Drawing.Point(116, 0);
            this.Titlebar_MinBtn.Name = "Titlebar_MinBtn";
            this.Titlebar_MinBtn.Size = new System.Drawing.Size(45, 30);
            this.Titlebar_MinBtn.TabIndex = 2;
            this.Titlebar_MinBtn.Text = "";
            this.Titlebar_MinBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Titlebar_MinMaxBtn
            // 
            this.Titlebar_MinMaxBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Titlebar_MinMaxBtn.Font = new System.Drawing.Font("Segoe Fluent Icons", 7F);
            this.Titlebar_MinMaxBtn.ForeColor = System.Drawing.Color.White;
            this.Titlebar_MinMaxBtn.Location = new System.Drawing.Point(161, 0);
            this.Titlebar_MinMaxBtn.Name = "Titlebar_MinMaxBtn";
            this.Titlebar_MinMaxBtn.Size = new System.Drawing.Size(45, 30);
            this.Titlebar_MinMaxBtn.TabIndex = 1;
            this.Titlebar_MinMaxBtn.Text = "";
            this.Titlebar_MinMaxBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Titlebar_XBtn
            // 
            this.Titlebar_XBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Titlebar_XBtn.Font = new System.Drawing.Font("Segoe Fluent Icons", 7F);
            this.Titlebar_XBtn.ForeColor = System.Drawing.Color.White;
            this.Titlebar_XBtn.Location = new System.Drawing.Point(206, 0);
            this.Titlebar_XBtn.Name = "Titlebar_XBtn";
            this.Titlebar_XBtn.Size = new System.Drawing.Size(45, 30);
            this.Titlebar_XBtn.TabIndex = 0;
            this.Titlebar_XBtn.Text = "";
            this.Titlebar_XBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 184);
            this.Controls.Add(this.TitleBarPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TitleBarPanel.ResumeLayout(false);
            this.TitleBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBar_IconPct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBarPanel;
        private ControlLabel Titlebar_XBtn;
        private ControlLabel Titlebar_MinBtn;
        private ControlLabel Titlebar_MinMaxBtn;
        private System.Windows.Forms.Label TitleBar_TitleLbl;
        private System.Windows.Forms.PictureBox TitleBar_IconPct;
    }
}

