namespace LocationVoiture
{
    partial class GestionVoiture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionVoiture));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.supprimerUneVoitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.modifierUneVoitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneVoitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeVoitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnClose = new System.Windows.Forms.Button();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listeDesVoituresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // supprimerUneVoitureToolStripMenuItem
            // 
            this.supprimerUneVoitureToolStripMenuItem.Name = "supprimerUneVoitureToolStripMenuItem";
            this.supprimerUneVoitureToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.supprimerUneVoitureToolStripMenuItem.Text = "Supprimer une voiture";
            this.supprimerUneVoitureToolStripMenuItem.Click += new System.EventHandler(this.supprimerUneVoitureToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-17, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(686, 369);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // modifierUneVoitureToolStripMenuItem
            // 
            this.modifierUneVoitureToolStripMenuItem.Name = "modifierUneVoitureToolStripMenuItem";
            this.modifierUneVoitureToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.modifierUneVoitureToolStripMenuItem.Text = "Modifier une voiture";
            this.modifierUneVoitureToolStripMenuItem.Click += new System.EventHandler(this.modifierUneVoitureToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.closeToolStripMenuItem.Text = "Quitter";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // ajouterUneVoitureToolStripMenuItem
            // 
            this.ajouterUneVoitureToolStripMenuItem.Name = "ajouterUneVoitureToolStripMenuItem";
            this.ajouterUneVoitureToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ajouterUneVoitureToolStripMenuItem.Text = "Ajouter une voiture";
            this.ajouterUneVoitureToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneVoitureToolStripMenuItem_Click);
            // 
            // gestionDeVoitureToolStripMenuItem
            // 
            this.gestionDeVoitureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesVoituresToolStripMenuItem,
            this.ajouterUneVoitureToolStripMenuItem,
            this.modifierUneVoitureToolStripMenuItem,
            this.supprimerUneVoitureToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.gestionDeVoitureToolStripMenuItem.Name = "gestionDeVoitureToolStripMenuItem";
            this.gestionDeVoitureToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.gestionDeVoitureToolStripMenuItem.Text = "Gestion de Voiture";
            // 
            // BtnClose
            // 
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(603, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(29, 24);
            this.BtnClose.TabIndex = 18;
            this.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeVoitureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listeDesVoituresToolStripMenuItem
            // 
            this.listeDesVoituresToolStripMenuItem.Name = "listeDesVoituresToolStripMenuItem";
            this.listeDesVoituresToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.listeDesVoituresToolStripMenuItem.Text = "Liste des voitures";
            this.listeDesVoituresToolStripMenuItem.Click += new System.EventHandler(this.listeDesVoituresToolStripMenuItem_Click);
            // 
            // GestionVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 359);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionVoiture";
            this.Text = "GestionVoiture";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDeVoitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneVoitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUneVoitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUneVoitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.ToolStripMenuItem listeDesVoituresToolStripMenuItem;
    }
}