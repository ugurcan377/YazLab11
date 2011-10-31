namespace YazLab_1
{
    partial class Form2
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
            this.kaynakEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaynakAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaynakçaOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaynakEkleToolStripMenuItem,
            this.kaynakAraToolStripMenuItem,
            this.kaynakçaOluşturToolStripMenuItem,
            this.kullanıcıAyarlarıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kaynakEkleToolStripMenuItem
            // 
            this.kaynakEkleToolStripMenuItem.Name = "kaynakEkleToolStripMenuItem";
            this.kaynakEkleToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.kaynakEkleToolStripMenuItem.Text = "Kaynak Ekle";
            this.kaynakEkleToolStripMenuItem.Click += new System.EventHandler(this.kaynakEkleToolStripMenuItem_Click);
            // 
            // kaynakAraToolStripMenuItem
            // 
            this.kaynakAraToolStripMenuItem.Name = "kaynakAraToolStripMenuItem";
            this.kaynakAraToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.kaynakAraToolStripMenuItem.Text = "Kaynak Ara";
            this.kaynakAraToolStripMenuItem.Click += new System.EventHandler(this.kaynakAraToolStripMenuItem_Click);
            // 
            // kaynakçaOluşturToolStripMenuItem
            // 
            this.kaynakçaOluşturToolStripMenuItem.Name = "kaynakçaOluşturToolStripMenuItem";
            this.kaynakçaOluşturToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.kaynakçaOluşturToolStripMenuItem.Text = "Kaynakça Oluştur";
            this.kaynakçaOluşturToolStripMenuItem.Click += new System.EventHandler(this.kaynakçaOluşturToolStripMenuItem_Click);
            // 
            // kullanıcıAyarlarıToolStripMenuItem
            // 
            this.kullanıcıAyarlarıToolStripMenuItem.Name = "kullanıcıAyarlarıToolStripMenuItem";
            this.kullanıcıAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.kullanıcıAyarlarıToolStripMenuItem.Text = "Kullanıcı Ayarları";
            this.kullanıcıAyarlarıToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıAyarlarıToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Referans Oluşturma Yazılımı";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kaynakEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaynakAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaynakçaOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıAyarlarıToolStripMenuItem;
    }
}