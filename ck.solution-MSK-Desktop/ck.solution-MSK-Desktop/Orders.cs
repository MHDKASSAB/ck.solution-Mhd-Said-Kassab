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
    public partial class Orders : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JQ7FI56\SQLEXPRESS;Initial Catalog=ckdb;Integrated Security=True");
        public Orders()
        {
            InitializeComponent();
            populate();
            OrderUpdate();
            itemname_txt.Enabled = false;
            itemqty_txt.Enabled = false;
        }
        void OrderUpdate()
        {
            con.Open();
            string MyQuery = "Select * From Orders";
            SqlDataAdapter sda = new SqlDataAdapter(MyQuery, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            order_dvg.DataSource = ds.Tables[0];
            con.Close();
        }
        void populate()
        {
            con.Open();
            string MyQuery = "Select ItemName, ItemPrice From Items";
            SqlDataAdapter sda = new SqlDataAdapter(MyQuery, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            items_dvg.DataSource = ds.Tables[0];
            con.Close();
        }
        private void back_btn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Orders_Load(object sender, EventArgs e)
        {

        }
        private void items_dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            itemname_txt.Text = items_dvg.Rows[0].Cells[0].Value.ToString();
            itemqty_txt.Text = items_dvg.Rows[0].Cells[1].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            date_lbl.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
        }
        int n = 0;
        int AllTotal = 0;
        private void addtocart_btn_Click(object sender, EventArgs e)
        {
            if (itemname_txt.Text == "" || price_txt.Text == "" )
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int Total = Convert.ToInt32(price_txt.Text) * Convert.ToInt32(itemqty_txt.Text);
                   
                DataGridViewRow view = new DataGridViewRow();
                view.CreateCells(cart_dvg);
                view.Cells[0].Value = n + 1;
                view.Cells[1].Value = itemname_txt.Text;
                view.Cells[3].Value = price_txt.Text;
                view.Cells[2].Value = itemqty_txt.Text;
                view.Cells[4].Value = Convert.ToInt32(price_txt.Text) * Convert.ToInt32(itemqty_txt.Text);
                n++;
                cart_dvg.Rows.Add(view);
                AllTotal = AllTotal + Total;
                euro_lbl.Text = "" + AllTotal + "€";
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand();
                com = new SqlCommand("Insert into Orders(OrderDate , Totalamount) Values ('" + date_lbl.Text + "' , '" + euro_lbl.Text + "')", con);
                com.ExecuteNonQuery();
                MessageBox.Show("Order Added Successfully", "Add Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                OrderUpdate();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
