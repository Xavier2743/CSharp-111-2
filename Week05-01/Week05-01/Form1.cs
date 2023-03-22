using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week05_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] lotteryNumbers = new int[6];

            Random rnd = new Random();

            for (int i = 0; i < lotteryNumbers.Length; i++)
            {
                int lotteryNumber = rnd.Next(1, 49);

                for (int j = 0; j < i; j++)
                {
                    if (lotteryNumber == lotteryNumbers[j])
                    {
                        lotteryNumber = rnd.Next(1, 49);
                        j = 0;
                    }
                }

                lotteryNumbers[i] = lotteryNumber;
            }

            textBox1.Text = "";
            foreach (var item in lotteryNumbers)
            {
                textBox1.Text += item + " ";
            }
        }
    }
}
