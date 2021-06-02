namespace LocationVoiture
{
    partial class GestionClient
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDeClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeClientToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDeClientToolStripMenuItem
            // 
            this.gestionDeClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDeClientsToolStripMenuItem,
            this.supprimerUnClientsToolStripMenuItem});
            this.gestionDeClientToolStripMenuItem.Name = "gestionDeClientToolStripMenuItem";
            this.gestionDeClientToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.gestionDeClientToolStripMenuItem.Text = "Gestion de Clients";
            // 
            // listeDeClientsToolStripMenuItem
            // 
            this.listeDeClientsToolStripMenuItem.Name = "listeDeClientsToolStripMenuItem";
            this.listeDeClientsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.listeDeClientsToolStripMenuItem.Text = "Liste de clients";
            this.listeDeClientsToolStripMenuItem.Click += new System.EventHandler(this.listeDeClientsToolStripMenuItem_Click);
            // 
            // supprimerUnClientsToolStripMenuItem
            // 
            this.supprimerUnClientsToolStripMenuItem.Name = "supprimerUnClientsToolStripMenuItem";
            this.supprimerUnClientsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.supprimerUnClientsToolStripMenuItem.Text = "Supprimer un clients";
            this.supprimerUnClientsToolStripMenuItem.Click += new System.EventHandler(this.supprimerUnClientsToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // GestionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 327);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GestionClient";
            this.Text = "GestionClient";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDeClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDeClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}