using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LocationVoiture
{
    public partial class Recherche : Form
    {
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        public Recherche()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                dt.Clear();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Client WHERE username like '%" + textBox1.Text + "%'", Program.cn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (radioButton2.Checked == true)
            {
                dt.Clear();
                dt2.Clear();
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM Voiture WHERE Matricule like '%" + textBox1.Text + "%'", Program.cn);
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous voullez quitter la forme de recherche ?", "Close", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void Recherche_Load(object sender, EventArgs e)
        {
            
        }
    }
}
