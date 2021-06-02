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
    public partial class SingUpForm : Form
    {
        public SingUpForm()
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

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous voullez quitter l'inscreption ?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox1.Focus();
        }


        private void BtnSingUp_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == String.Empty && textBox2.Text == String.Empty && textBox3.Text == String.Empty && textBox4.Text == String.Empty && textBox5.Text == String.Empty && textBox6.Text == String.Empty && textBox7.Text == String.Empty)
                {
                    MessageBox.Show("Veuillez remplir les champs !");
                }
                else
                {
                    cnx();
                    Program.cmd = new SqlCommand("InsertClient", Program.cn);
                    Program.cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter[] param = new SqlParameter[7];

                    param[0] = new SqlParameter("username", SqlDbType.VarChar, 50);
                    param[0].Value = textBox1.Text;

                    param[1] = new SqlParameter("LastName", SqlDbType.VarChar, 50);
                    param[1].Value = textBox2.Text;

                    param[2] = new SqlParameter("FirstName", SqlDbType.VarChar, 50);
                    param[2].Value = textBox3.Text;

                    param[3] = new SqlParameter("Adresse", SqlDbType.VarChar, 50);
                    param[3].Value = textBox4.Text;

                    param[4] = new SqlParameter("Tele", SqlDbType.VarChar, 50);
                    param[4].Value = textBox5.Text;

                    param[5] = new SqlParameter("CIN", SqlDbType.VarChar, 50);
                    param[5].Value = textBox6.Text;

                    param[6] = new SqlParameter("ModPasse", SqlDbType.VarChar, 50);
                    param[6].Value = textBox7.Text;

                    Program.cmd.Parameters.AddRange(param);
                    Program.cmd.ExecuteNonQuery();
                    MessageBox.Show("Sing up seccussfelly ! You can log in now..");

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox1.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
