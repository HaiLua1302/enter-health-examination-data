
namespace khamsk
{
    partial class formKSK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formKSK));
            this.menuTop = new System.Windows.Forms.MenuStrip();
            this.kSKTT14ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kSKLAIXEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTop
            // 
            this.menuTop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kSKTT14ToolStripMenuItem,
            this.kSKLAIXEToolStripMenuItem});
            this.menuTop.Location = new System.Drawing.Point(0, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(1215, 28);
            this.menuTop.TabIndex = 0;
            this.menuTop.Text = "menuStrip1";
            // 
            // kSKTT14ToolStripMenuItem
            // 
            this.kSKTT14ToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.kSKTT14ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.kSKTT14ToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.kSKTT14ToolStripMenuItem.Name = "kSKTT14ToolStripMenuItem";
            this.kSKTT14ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.kSKTT14ToolStripMenuItem.Text = "1. KSK TT14";
            this.kSKTT14ToolStripMenuItem.Click += new System.EventHandler(this.kSKTT14ToolStripMenuItem_Click);
            // 
            // kSKLAIXEToolStripMenuItem
            // 
            this.kSKLAIXEToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.kSKLAIXEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.kSKLAIXEToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.kSKLAIXEToolStripMenuItem.Name = "kSKLAIXEToolStripMenuItem";
            this.kSKLAIXEToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.kSKLAIXEToolStripMenuItem.Text = "2. KSK LAI XE";
            this.kSKLAIXEToolStripMenuItem.Click += new System.EventHandler(this.kSKLAIXEToolStripMenuItem_Click);
            // 
            // formKSK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1215, 681);
            this.Controls.Add(this.menuTop);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuTop;
            this.Name = "formKSK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM LƯU THÔNG TIN KHÁM SỨC KHOẺ - BỆNH VIỆN LÊ VĂN VIỆT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.main_Load);
            this.menuTop.ResumeLayout(false);
            this.menuTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTop;
        private System.Windows.Forms.ToolStripMenuItem kSKTT14ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kSKLAIXEToolStripMenuItem;
    }
}