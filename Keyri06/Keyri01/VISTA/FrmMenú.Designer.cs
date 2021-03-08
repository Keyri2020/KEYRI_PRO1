
namespace Keyri01.VISTA
{
    partial class FrmMenú
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
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clickParaMásInformaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arreglosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.matemáticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.arreglosToolStripMenuItem,
            this.matemáticasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clickParaMásInformaciónToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // clickParaMásInformaciónToolStripMenuItem
            // 
            this.clickParaMásInformaciónToolStripMenuItem.Name = "clickParaMásInformaciónToolStripMenuItem";
            this.clickParaMásInformaciónToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.clickParaMásInformaciónToolStripMenuItem.Text = "Click para más información";
            this.clickParaMásInformaciónToolStripMenuItem.Click += new System.EventHandler(this.clickParaMásInformaciónToolStripMenuItem_Click);
            // 
            // arreglosToolStripMenuItem
            // 
            this.arreglosToolStripMenuItem.Name = "arreglosToolStripMenuItem";
            this.arreglosToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.arreglosToolStripMenuItem.Text = "Ejemplos de arreglos";
            this.arreglosToolStripMenuItem.Click += new System.EventHandler(this.arreglosToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // matemáticasToolStripMenuItem
            // 
            this.matemáticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaToolStripMenuItem,
            this.restaToolStripMenuItem});
            this.matemáticasToolStripMenuItem.Name = "matemáticasToolStripMenuItem";
            this.matemáticasToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.matemáticasToolStripMenuItem.Text = "Matemáticas";
            // 
            // sumaToolStripMenuItem
            // 
            this.sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            this.sumaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sumaToolStripMenuItem.Text = "Suma";
            this.sumaToolStripMenuItem.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // restaToolStripMenuItem
            // 
            this.restaToolStripMenuItem.Name = "restaToolStripMenuItem";
            this.restaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restaToolStripMenuItem.Text = "Resta";
            this.restaToolStripMenuItem.Click += new System.EventHandler(this.restaToolStripMenuItem_Click);
            // 
            // FrmMenú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenú";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menú";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenú_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clickParaMásInformaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arreglosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem matemáticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaToolStripMenuItem;
    }
}