using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ck.solution_MSK_Desktop
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JQ7FI56\SQLEXPRESS;Initial Catalog=ckdb;Integrated Security=True");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("Select * from Users where Username = '" + username_txt.Text + "'" +
                    "and UserPassword = '" + password_txt.Text + "'", con);
                con.Open();
                SqlDataReader sdr = com.ExecuteReader();
                sdr.Read();
                if (sdr.HasRows)
                {
                    MessageBox.Show("Welcom " + sdr["Username"].ToString(), "LogIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invaild UserName or Password", "LogIn Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reg_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageUsers users = new ManageUsers();
            users.Show();
            this.Hide();
        }
    }
}
