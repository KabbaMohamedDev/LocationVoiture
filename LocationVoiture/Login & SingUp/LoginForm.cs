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
    public partial class LoginForm : Form
    {
        public LoginForm()
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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Client")
                {
                    cnx();
                    Program.da = new SqlDataAdapter("Select count(*) from Client where username='" + textBox1.Text + "' and modpasse ='" + textBox2.Text + "'", Program.cn);

                    DataTable dt = new DataTable();
                    Program.da.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        MessageBox.Show("Login seccussfull");
                        AdminForm af = new AdminForm();
                        af.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }

                else if (comboBox1.Text == "Admin")
                {
                    if (textBox1.Text == "Admin" && textBox2.Text == "123")
                    {
                        MessageBox.Show("Login seccussfull");
                        AdminForm af = new AdminForm();
                        af.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("error");
                    }
                }
                else
                {
                    MessageBox.Show("Choose a role");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSingUp_Click(object sender, EventArgs e)
        {
            SingUpForm su = new SingUpForm();
            su.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous voullez quitter l'application ?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Admin";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "User Name")
            {
                textBox1.Text = "";

                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";

                textBox2.ForeColor = Color.Black;
            }
        }
    }
}
