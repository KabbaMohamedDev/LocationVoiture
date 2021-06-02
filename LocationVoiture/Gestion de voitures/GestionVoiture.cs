using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LocationVoiture
{
    public partial class GestionVoiture : Form
    {
        public GestionVoiture()
        {
            InitializeComponent();
        }

        private void ajouterUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterVoiture av = new AjouterVoiture();
            av.Show();
        }

        private void modifierUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierVoiture mv = new ModifierVoiture();
            mv.Show();
        }

        private void supprimerUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerVoiture sv = new SupprimerVoiture();
            sv.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous voullez quitter la forme de gestion ?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous voullez quitter la forme de gestion ?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void listeDesVoituresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListVoiture lv = new ListVoiture();
            lv.Show();
        }
    }
}
