namespace Week08_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text = radioButton1.Text;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox1.Text = radioButton2.Text;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox1.Text = "Unknown";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            showFood();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            showFood();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            showFood();
        }

        private void showFood()
        {
            textBox2.Text = "";
            if (checkBox1.Checked)
            {
                textBox2.Text += (checkBox1.Text + "\r\n");
            }
            if (checkBox2.Checked)
            {
                textBox2.Text += checkBox2.Text + "\r\n";
            }
            if (checkBox3.Checked)
            {
                textBox2.Text += checkBox3.Text + "\r\n";
            }
        }
    }
}