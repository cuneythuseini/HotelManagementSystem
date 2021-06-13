namespace Hotel_Management_System
{
    partial class FrmNewsPaper
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.новаМакедонијаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.канал5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сителToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спортскиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спортКлубToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 29);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(815, 403);
            this.webBrowser1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаМакедонијаToolStripMenuItem,
            this.канал5ToolStripMenuItem,
            this.сителToolStripMenuItem,
            this.спортскиToolStripMenuItem,
            this.спортКлубToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // новаМакедонијаToolStripMenuItem
            // 
            this.новаМакедонијаToolStripMenuItem.Name = "новаМакедонијаToolStripMenuItem";
            this.новаМакедонијаToolStripMenuItem.Size = new System.Drawing.Size(155, 25);
            this.новаМакедонијаToolStripMenuItem.Text = "Нова Македонија";
            this.новаМакедонијаToolStripMenuItem.Click += new System.EventHandler(this.новаМакедонијаToolStripMenuItem_Click);
            // 
            // канал5ToolStripMenuItem
            // 
            this.канал5ToolStripMenuItem.Name = "канал5ToolStripMenuItem";
            this.канал5ToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.канал5ToolStripMenuItem.Text = "Канал-5";
            this.канал5ToolStripMenuItem.Click += new System.EventHandler(this.канал5ToolStripMenuItem_Click);
            // 
            // сителToolStripMenuItem
            // 
            this.сителToolStripMenuItem.Name = "сителToolStripMenuItem";
            this.сителToolStripMenuItem.Size = new System.Drawing.Size(67, 25);
            this.сителToolStripMenuItem.Text = "Сител";
            this.сителToolStripMenuItem.Click += new System.EventHandler(this.сителToolStripMenuItem_Click);
            // 
            // спортскиToolStripMenuItem
            // 
            this.спортскиToolStripMenuItem.Name = "спортскиToolStripMenuItem";
            this.спортскиToolStripMenuItem.Size = new System.Drawing.Size(94, 25);
            this.спортскиToolStripMenuItem.Text = "Спортски";
            this.спортскиToolStripMenuItem.Click += new System.EventHandler(this.спортскиToolStripMenuItem_Click);
            // 
            // спортКлубToolStripMenuItem
            // 
            this.спортКлубToolStripMenuItem.Name = "спортКлубToolStripMenuItem";
            this.спортКлубToolStripMenuItem.Size = new System.Drawing.Size(109, 25);
            this.спортКлубToolStripMenuItem.Text = "Спорт Клуб";
            this.спортКлубToolStripMenuItem.Click += new System.EventHandler(this.спортКлубToolStripMenuItem_Click);
            // 
            // FrmNewsPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 432);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmNewsPaper";
            this.Text = "Весник";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem новаМакедонијаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem канал5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сителToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спортскиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спортКлубToolStripMenuItem;
    }
}