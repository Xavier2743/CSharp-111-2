using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week04_04_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int item = Convert.ToInt32(textBox1.Text);
            double temp = 0;

            for (int i = 0; i < item; i++)
            {
                if(i % 2 == 0) {
                    temp += (double)1 / (2 * i + 1);
                }
                else {
                    temp -= (double)1 / (2 * i + 1);
                }
            }

            temp *= 4;

            label1.Text = temp.ToString();
        }
    }
}
