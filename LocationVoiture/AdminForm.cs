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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            GestionClient gc = new GestionClient();
            gc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GestionVoiture gv = new GestionVoiture();
            gv.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous voullez quitter l'application ?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous voullez quitter l'application ?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Recherche r = new Recherche();
            r.Show();
        }
    }
}
