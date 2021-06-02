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
    public partial class ListeClient : Form
    {

        DataTable dt = new DataTable();
 
        public ListeClient()
        {
            InitializeComponent();
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

        private void ListeClient_Load(object sender, EventArgs e)
        {
            fillDataGrid();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous voullez quitter ?", "Close", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
            else
            {

            }
        }
    }
}
