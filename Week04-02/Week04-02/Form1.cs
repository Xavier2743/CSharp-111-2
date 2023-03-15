using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week04_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int income = Convert.ToInt32(textBox1.Text);
            double tax = 0;

            if (income < 500000)
            {
                tax = income * 0.05;
            }
            else if (income < 1000000)
            {
                tax = income * 0.1 - 25000;
            }
            else if (income < 2000000)
            {
                tax = income * 0.2 - 125000;
            }
            else if (income < 4000000)
            {
                tax = income * 0.3 - 325000;
            }
            else
            {
                tax = income * 0.4 - 625000;
            }

            label2.Text = "Tax: " + tax.ToString("N");
        }
    }
}
