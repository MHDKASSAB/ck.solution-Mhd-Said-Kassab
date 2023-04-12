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
    public partial class ManageUsers : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JQ7FI56\SQLEXPRESS;Initial Catalog=ckdb;Integrated Security=True");
        public ManageUsers()
        {
            InitializeComponent();
            UserUpdate();
        }

        public void UserUpdate()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda = new SqlDataAdapter("Select * from Users", con);
            SqlCommandBuilder scb = new SqlCommandBuilder();
            scb = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            users_dvg.DataSource = ds.Tables[0];
            con.Close();
        }
        public void Clear()
        {
            username_txt.Text = "";
            password_txt.Text = "";
            mobile_txt.Text = "";
            Key = 0;
        }
        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int Key = 0;
        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand();
                com = new SqlCommand("Insert into Users(UserName , UserPassword , UserTelefone) Values ('" + username_txt.Text + "' , '" + password_txt.Text + "' , '" + mobile_txt.Text + "')", con);
                com.ExecuteNonQuery();
                MessageBox.Show("User Added Successfully", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                UserUpdate();
                Clear();
                add_btn.Enabled = true;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (username_txt.Text == "" || password_txt.Text == ""
                || mobile_txt.Text == "")
            {
                MessageBox.Show("Missing Information", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand();
                    com = new SqlCommand("Update Users set [UserName]='" + username_txt.Text + "' , [UserPassword] ='" + password_txt.Text + "', [UserTelefone]='" + mobile_txt.Text + "' where UserId = '" + Key + "'", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("User Updated Successfully", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    UserUpdate();
                    Clear();
                    add_btn.Enabled = true;
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message, "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select User !! ", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand();
                    com = new SqlCommand("Delete Users where UserId = '" + Key + "'", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    UserUpdate();
                    Clear();
                    add_btn.Enabled = true;
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message, "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void users_dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            add_btn.Enabled = false;
            int i = e.RowIndex;
            DataGridViewRow row = users_dvg.Rows[i];
            username_txt.Text = row.Cells[1].Value.ToString();
            password_txt.Text = row.Cells[2].Value.ToString();
            mobile_txt.Text = row.Cells[3].Value.ToString();


            if (username_txt.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {

        }
    }
}
