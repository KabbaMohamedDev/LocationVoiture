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
    public partial class GestionClient : Form
    {
        public GestionClient()
        {
            InitializeComponent();
        }

        private void listeDeClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeClient lc = new ListeClient();
            lc.Show();
        }

        private void supprimerUnClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerClient sc = new SupprimerClient();
            sc.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous voullez quitter la Gestion de Client ?", "Close", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
            else
            {

            }
        }
    }
}
