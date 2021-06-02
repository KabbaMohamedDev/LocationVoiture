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
    public partial class AjouterVoiture : Form
    {

        DataTable dt = new DataTable();
        public AjouterVoiture()
        {
            InitializeComponent();
            fillDataGrid();
        }

        public void cnx()
        {
            if (Program.cn.State == ConnectionState.Closed)
            {
                Program.cn.Open();
            }
        }

        void fillDataGrid()
        {
            cnx();
            dt.Clear();
            Program.cmd = new SqlCommand("SelectVoiture", Program.cn);
            Program.cmd.CommandType = CommandType.StoredProcedure;
            Program.da = new SqlDataAdapter(Program.cmd);
            Program.da.Fill(dt);
            this.dataGridView1.DataSource = dt;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous voullez quitter la forme d'ajout ?", "Close", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void BtnVider_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous voullez quitter la forme d'ajout ?", "Close", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                cnx();
                Program.cmd = new SqlCommand("InsertVoiture", Program.cn);
                Program.cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter[] param = new SqlParameter[4];

                param[0] = new SqlParameter("@Matricule", SqlDbType.VarChar, 50);
                param[0].Value = textBox1.Text;

                param[1] = new SqlParameter("@Marque", SqlDbType.VarChar, 50);
                param[1].Value = textBox2.Text;

                param[2] = new SqlParameter("@Modelle", SqlDbType.VarChar, 50);
                param[2].Value = textBox3.Text;

                param[3] = new SqlParameter("@Kilometrage", SqlDbType.Int);
                param[3].Value = textBox4.Text;

                Program.cmd.Parameters.AddRange(param);

                Program.cmd.ExecuteNonQuery(); 

                MessageBox.Show("Added seccessfully !", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillDataGrid();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AjouterVoiture_Load(object sender, EventArgs e)
        {

        }
    }
}
