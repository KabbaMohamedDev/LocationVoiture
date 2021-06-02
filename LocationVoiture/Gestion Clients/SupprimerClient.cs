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
    public partial class SupprimerClient : Form
    {
        
        DataTable dt = new DataTable();

        public SupprimerClient()
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
            Program.cmd = new SqlCommand("SelectClient", Program.cn);
            Program.cmd.CommandType = CommandType.StoredProcedure;
            Program.da = new SqlDataAdapter(Program.cmd);
            Program.da.Fill(dt);
            this.dataGridView1.DataSource = dt;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous voulez quitter ?", "Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                cnx();
                Program.cmd = new SqlCommand("DeleteClient", Program.cn);
                Program.cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();

                param = new SqlParameter("@username", SqlDbType.VarChar, 50);
                param.Value = textBox1.Text;

                Program.cmd.Parameters.Add(param);
                Program.cmd.ExecuteNonQuery();

                MessageBox.Show("Deleted seccessfully !", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                fillDataGrid();
                textBox1.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void SupprimerClient_Load(object sender, EventArgs e)
        {

        }
    }
}
