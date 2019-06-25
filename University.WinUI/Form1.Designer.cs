namespace University.WinUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eğitmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eğitmenKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eğitmenDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciToolStripMenuItem,
            this.eğitmenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciToolStripMenuItem
            // 
            this.öğrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciKaydıToolStripMenuItem,
            this.öğrenciDüzenlemeToolStripMenuItem});
            this.öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            this.öğrenciToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.öğrenciToolStripMenuItem.Text = "Öğrenci";
            // 
            // eğitmenToolStripMenuItem
            // 
            this.eğitmenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eğitmenKaydıToolStripMenuItem,
            this.eğitmenDüzenlemeToolStripMenuItem});
            this.eğitmenToolStripMenuItem.Name = "eğitmenToolStripMenuItem";
            this.eğitmenToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.eğitmenToolStripMenuItem.Text = "Eğitmen";
            // 
            // öğrenciKaydıToolStripMenuItem
            // 
            this.öğrenciKaydıToolStripMenuItem.Name = "öğrenciKaydıToolStripMenuItem";
            this.öğrenciKaydıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öğrenciKaydıToolStripMenuItem.Text = "Öğrenci Kaydı";
            this.öğrenciKaydıToolStripMenuItem.Click += new System.EventHandler(this.öğrenciKaydıToolStripMenuItem_Click);
            // 
            // öğrenciDüzenlemeToolStripMenuItem
            // 
            this.öğrenciDüzenlemeToolStripMenuItem.Name = "öğrenciDüzenlemeToolStripMenuItem";
            this.öğrenciDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öğrenciDüzenlemeToolStripMenuItem.Text = "Öğrenci Düzenleme";
            this.öğrenciDüzenlemeToolStripMenuItem.Click += new System.EventHandler(this.öğrenciDüzenlemeToolStripMenuItem_Click);
            // 
            // eğitmenKaydıToolStripMenuItem
            // 
            this.eğitmenKaydıToolStripMenuItem.Name = "eğitmenKaydıToolStripMenuItem";
            this.eğitmenKaydıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eğitmenKaydıToolStripMenuItem.Text = "Eğitmen Kaydı";
            this.eğitmenKaydıToolStripMenuItem.Click += new System.EventHandler(this.eğitmenKaydıToolStripMenuItem_Click);
            // 
            // eğitmenDüzenlemeToolStripMenuItem
            // 
            this.eğitmenDüzenlemeToolStripMenuItem.Name = "eğitmenDüzenlemeToolStripMenuItem";
            this.eğitmenDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eğitmenDüzenlemeToolStripMenuItem.Text = "Eğitmen Düzenleme";
            this.eğitmenDüzenlemeToolStripMenuItem.Click += new System.EventHandler(this.eğitmenDüzenlemeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "University";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eğitmenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eğitmenKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eğitmenDüzenlemeToolStripMenuItem;
    }
}

