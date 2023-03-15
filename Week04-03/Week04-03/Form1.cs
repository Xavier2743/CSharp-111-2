using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week04_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(textBox1.Text);
            string result = "";

            if (year % 4 != 0) {
                result = "Common Year";
            }
            else
            {
                if (year % 400 == 0)
                {
                    result = "Leap Year";
                }
                else if (year % 100 == 0)
                {
                    result = "Common Year";
                }
                else
                {
                    result = "Leap Year";
                }
            }

            label1.Text = result;
        }
    }
}
