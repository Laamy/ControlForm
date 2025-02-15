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
            this.Titlebar_MinBtn = new ControlLabel();
            this.Titlebar_MinMaxBtn = new ControlLabel();
            this.Titlebar_XBtn = new ControlLabel();
            this.TitleBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.BackColor = System.Drawing.SystemColors.Control;
            this.TitleBarPanel.Controls.Add(this.Titlebar_MinBtn);
            this.TitleBarPanel.Controls.Add(this.Titlebar_MinMaxBtn);
            this.TitleBarPanel.Controls.Add(this.Titlebar_XBtn);
            this.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleBarPanel.Name = "TitleBarPanel";
            this.TitleBarPanel.Size = new System.Drawing.Size(327, 32);
            this.TitleBarPanel.TabIndex = 0;
            // 
            // Titlebar_MinBtn
            // 
            this.Titlebar_MinBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Titlebar_MinBtn.Font = new System.Drawing.Font("Segoe Fluent Icons", 7F);
            this.Titlebar_MinBtn.ForeColor = System.Drawing.Color.White;
            this.Titlebar_MinBtn.Location = new System.Drawing.Point(192, 0);
            this.Titlebar_MinBtn.Name = "Titlebar_MinBtn";
            this.Titlebar_MinBtn.Size = new System.Drawing.Size(45, 32);
            this.Titlebar_MinBtn.TabIndex = 2;
            this.Titlebar_MinBtn.Text = "";
            this.Titlebar_MinBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Titlebar_MinMaxBtn
            // 
            this.Titlebar_MinMaxBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Titlebar_MinMaxBtn.Font = new System.Drawing.Font("Segoe Fluent Icons", 7F);
            this.Titlebar_MinMaxBtn.ForeColor = System.Drawing.Color.White;
            this.Titlebar_MinMaxBtn.Location = new System.Drawing.Point(237, 0);
            this.Titlebar_MinMaxBtn.Name = "Titlebar_MinMaxBtn";
            this.Titlebar_MinMaxBtn.Size = new System.Drawing.Size(45, 32);
            this.Titlebar_MinMaxBtn.TabIndex = 1;
            this.Titlebar_MinMaxBtn.Text = "";
            this.Titlebar_MinMaxBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Titlebar_XBtn
            // 
            this.Titlebar_XBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Titlebar_XBtn.Font = new System.Drawing.Font("Segoe Fluent Icons", 7F);
            this.Titlebar_XBtn.ForeColor = System.Drawing.Color.White;
            this.Titlebar_XBtn.Location = new System.Drawing.Point(282, 0);
            this.Titlebar_XBtn.Name = "Titlebar_XBtn";
            this.Titlebar_XBtn.Size = new System.Drawing.Size(45, 32);
            this.Titlebar_XBtn.TabIndex = 0;
            this.Titlebar_XBtn.Text = "";
            this.Titlebar_XBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 406);
            this.Controls.Add(this.TitleBarPanel);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TitleBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBarPanel;
        private ControlLabel Titlebar_XBtn;
        private ControlLabel Titlebar_MinBtn;
        private ControlLabel Titlebar_MinMaxBtn;
    }
}

