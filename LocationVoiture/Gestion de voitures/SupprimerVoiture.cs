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
    public partial class SupprimerVoiture : Form
    {

        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();

        public SupprimerVoiture()
        {
            InitializeComponent();
            fillDataGrid();
            fillcombo();
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

        void fillcombo()
        {
            dt2.Clear();
            Program.da2 = new SqlDataAdapter("Select * from Voiture", Program.cn);
            Program.da2.Fill(dt2);
            comboBox1.DataSource = dt2;
            comboBox1.DisplayMember = "Matricule";
        }

        private void SupprimerVoiture_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous voullez quitter la forme de suppression ?", "Close", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous voullez quitter la forme de suppression ?", "Close", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void BtnVider_Click(object sender, EventArgs e)
        {

        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                cnx();
                Program.cmd = new SqlCommand("DeleteVoiture", Program.cn);
                Program.cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();

                param = new SqlParameter("@Matricule", SqlDbType.VarChar, 50);
                param.Value = comboBox1.Text;

                Program.cmd.Parameters.Add(param);
                Program.cmd.ExecuteNonQuery();

                MessageBox.Show("Deleted seccessfully !", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                fillDataGrid();
                fillcombo();

                comboBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
