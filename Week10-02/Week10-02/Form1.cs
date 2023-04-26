namespace Week10_02
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
                label1.Text = radioButton1.Text;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label1.Text = radioButton2.Text;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label1.Text = radioButton3.Text;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                label2.Text = radioButton4.Text;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                label2.Text = radioButton5.Text;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                label2.Text = radioButton6.Text;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton7.Checked)
            {
                label3.Text = radioButton7.Text;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton8.Checked)
            {
                label3.Text = radioButton8.Text;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton9.Checked)
            {
                label3.Text = radioButton9.Text;
            }
        }
    }
}