using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week05_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int row = Convert.ToInt32(textBox1.Text);
            int[,] pascalTriangle = new int[row, row];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (j == 0 || i == j)
                    {
                        pascalTriangle[i, j] = 1;
                    }
                    else
                    {
                        pascalTriangle[i, j] = pascalTriangle[i - 1, j - 1] + pascalTriangle[i - 1, j];
                    }
                }
            }

            textBox2.Text = "";
            for (int i = 0; i< row; i++)
            {
                for (int j = 0;j < row; j++)
                {
                    textBox2.Text += pascalTriangle[i, j].ToString() + " ";
                }
                textBox2.Text += "\n";
            }
        }
    }
}
