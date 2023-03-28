using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week03_HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int[] prizes = { 100, 1000, 10000, 100000 };

        private void button1_Click(object sender, EventArgs e)
        {
            scratch(labelY1, labelO1, labelP1, button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scratch(labelY2, labelO2, labelP2, button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            scratch(labelY3, labelO3, labelP3, button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            scratch(labelY4, labelO4, labelP4, button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            scratch(labelY5, labelO5, labelP5, button5);
        }

        private void scratch(Label yourLabel, Label opponentLLabel, Label prizeLabel, Button scratchButton)
        {
            int yourNumber = rnd.Next(20, 30);
            int opponentNumber = rnd.Next(20, 30);
            int prizeIndex = rnd.Next(prizes.Length);
            yourLabel.Text = yourNumber.ToString();
            opponentLLabel.Text = opponentNumber.ToString();
            prizeLabel.Text = prizes[prizeIndex].ToString();
            scratchButton.Enabled = false;
        }
    }
}
