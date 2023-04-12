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
    public partial class Items : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JQ7FI56\SQLEXPRESS;Initial Catalog=ckdb;Integrated Security=True");
        public Items()
        {
            InitializeComponent();
            ItemsUpdate();
        }
        public void ItemsUpdate()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda = new SqlDataAdapter("Select * from Items", con);
            SqlCommandBuilder scb = new SqlCommandBuilder();
            scb = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            items_dvg.DataSource = ds.Tables[0];
            con.Close();
        }
        public void Clear()
        {
            price_txt.Text = "";
            desc_txt.Text = "";
            name_txt.Text = "";
            qty_txt.Text = "";
            Key = 0;
        }
        int Key = 0;
        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand();
                com = new SqlCommand("Insert into Items(ItemName, ItemPrice , ItemDesc, ItemQty) Values ('" + name_txt.Text + "','" + price_txt.Text + "' , '" + desc_txt.Text + "' , '" + qty_txt.Text + "')", con);
                com.ExecuteNonQuery();
                MessageBox.Show("Item Added Successfully", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                ItemsUpdate();
                Clear();
                add_btn.Enabled = true;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Item Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (name_txt.Text=="" || price_txt.Text == "" || desc_txt.Text == "")
            {
                MessageBox.Show("Missing Information", "Item Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand();
                    com = new SqlCommand("Update Items set [ItemName]='" + name_txt.Text + "',[ItemPrice]='" + price_txt.Text + "' , [ItemDesc] ='" + desc_txt.Text + "', [ItemQty] = '" + qty_txt + "' where ItemId = '" + Key + "'", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Item Updated Successfully", "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    ItemsUpdate();
                    Clear();
                    add_btn.Enabled = true;
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message, "Item Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select Item !! ", "Item Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand();
                    com = new SqlCommand("Delete Items where ItemId = '" + Key + "'", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Item Deleted Successfully", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    ItemsUpdate();
                    Clear();
                    add_btn.Enabled = true;
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message, "Item Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void items_dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            add_btn.Enabled = false;
            int i = e.RowIndex;
            DataGridViewRow row = items_dvg.Rows[i];
            name_txt.Text = row.Cells[1].Value.ToString();
            price_txt.Text = row.Cells[2].Value.ToString();
            desc_txt.Text = row.Cells[3].Value.ToString();
            qty_txt.Text = row.Cells[4].Value.ToString();

            if (name_txt.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
