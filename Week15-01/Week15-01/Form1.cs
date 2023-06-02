using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Week15_01
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        int orderID = 0;

        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vic\Desktop\CSharp-111-2\Week15-01\DB\pos.mdf;Integrated Security=True;Connect Timeout=30");
            displayOrder();
        }

        private void displayOrder()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM mOrder", con);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Order ID";
            dataGridView1.Columns[1].HeaderText = "Item Name";
            dataGridView1.Columns[2].HeaderText = "Price";
            dataGridView1.Columns[3].HeaderText = "Quantity";
            dataGridView1.Columns[4].HeaderText = "Total";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Burger";
            textBox2.Text = "60";
            numericUpDown1.Value = 1;
            textBox3.Text = "60";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Coke";
            textBox2.Text = "30";
            numericUpDown1.Value = 1;
            textBox3.Text = "30";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Rice";
            textBox2.Text = "20";
            numericUpDown1.Value = 1;
            textBox3.Text = "20";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Noddle";
            textBox2.Text = "50";
            numericUpDown1.Value = 1;
            textBox3.Text = "50";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                int price = Convert.ToInt32(textBox2.Text);
                int quantity = Convert.ToInt32(numericUpDown1.Value);
                int total = price * quantity;
                textBox3.Text = total.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO mOrder (orderName, orderPrice, orderNum, orderTotal) VALUES (@orderName, @orderPrice, @orderNum, @orderTotal)", con);
                cmd.Parameters.AddWithValue("@orderName", textBox1.Text);
                cmd.Parameters.AddWithValue("@orderPrice", Convert.ToInt32(textBox2.Text));
                cmd.Parameters.AddWithValue("@orderNum", numericUpDown1.Value);
                cmd.Parameters.AddWithValue("@orderTotal", Convert.ToInt32(textBox3.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                displayOrder();
                textBox1.Text = "";
                textBox2.Text = "";
                numericUpDown1.Value = 0;
                textBox3.Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("DELETE mOrder WHERE orderID = @orderID", con);
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.ExecuteNonQuery();
            con.Close();
            displayOrder();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            orderID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}
