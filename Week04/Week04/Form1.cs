﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int height = Convert.ToInt32(textBox1.Text);
            int weight = Convert.ToInt32(textBox2.Text);
            double bmi = weight / Math.Pow((double)height / 100, 2);

            string bmi_message = "";

            if (bmi < 18)
            {
                bmi_message = "(light)";
            }
            else if (bmi < 24)
            {
                bmi_message = "(normal)";
            }
            else if (bmi < 27)
            {
                bmi_message = "(kind of heavy)";
            }
            else {
                bmi_message = "(too heavy)";
            }

            label5.Text = "BMI: " + bmi.ToString("0.00") + " " + bmi_message;
        }
    }
}
