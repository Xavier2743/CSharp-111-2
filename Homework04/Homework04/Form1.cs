using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Homework04
{
    public partial class Form1 : Form
    {
        SqlConnection con0;
        SqlCommand cmd0;
        SqlDataAdapter adapter0;

        SqlConnection con1;
        SqlCommand cmd1;
        SqlDataAdapter adapter1;

        int orderID = 0;

        public Form1()
        {
            InitializeComponent();
            con0 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vic\Desktop\CSharp-111-2\Homework04\DB\pos.mdf;Integrated Security=True;Connect Timeout=30");
            con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vic\Desktop\CSharp-111-2\Homework04\DB\meals.mdf;Integrated Security=True;Connect Timeout=30");
            displayOrder();
        }

        private void displayOrder()
        {
            con0.Open();
            DataTable dt = new DataTable();
            adapter0 = new SqlDataAdapter("SELECT * FROM mOrder", con0);
            adapter0.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Order ID";
            dataGridView1.Columns[1].HeaderText = "Item Name";
            dataGridView1.Columns[2].HeaderText = "Price";
            dataGridView1.Columns[3].HeaderText = "Quantity";
            dataGridView1.Columns[4].HeaderText = "Total";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con0.Close();
        }

        private void queryMeal(int mealID)
        {
            con1.Open();
            DataTable dt = new DataTable();
            adapter1 = new SqlDataAdapter("SELECT * FROM mealTable WHERE mealId = '" + mealID + "'", con1);
            adapter1.Fill(dt);
            String name = dt.Rows[0].Field<String>(1);
            int price = dt.Rows[0].Field<int>(2);
            con1.Close();
            textBox1.Text = name;
            textBox2.Text = price + "";
            numericUpDown1.Value = 1;
            textBox3.Text = price + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            queryMeal(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            queryMeal(4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            queryMeal(5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            queryMeal(7);
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
                con0.Open();
                cmd0 = new SqlCommand("INSERT INTO mOrder (orderName, orderPrice, orderNum, orderTotal) VALUES (@orderName, @orderPrice, @orderNum, @orderTotal)", con0);
                cmd0.Parameters.AddWithValue("@orderName", textBox1.Text);
                cmd0.Parameters.AddWithValue("@orderPrice", Convert.ToInt32(textBox2.Text));
                cmd0.Parameters.AddWithValue("@orderNum", numericUpDown1.Value);
                cmd0.Parameters.AddWithValue("@orderTotal", Convert.ToInt32(textBox3.Text));
                cmd0.ExecuteNonQuery();
                con0.Close();
                displayOrder();
                textBox1.Text = "";
                textBox2.Text = "";
                numericUpDown1.Value = 0;
                textBox3.Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con0.Open();
            cmd0 = new SqlCommand("DELETE mOrder WHERE orderID = @orderID", con0);
            cmd0.Parameters.AddWithValue("@orderID", orderID);
            cmd0.ExecuteNonQuery();
            con0.Close();
            displayOrder();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            orderID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}