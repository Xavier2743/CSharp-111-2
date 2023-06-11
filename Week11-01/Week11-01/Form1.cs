namespace Week11_01
{
    public partial class Form1 : Form
    {
        int[] numbers;
        PictureBox[] pictureBoxes;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            numbers = new int[9];
            pictureBoxes = new PictureBox[9] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lines = 0;

            pictureBox_Show(pictureBox11, 9);
            pictureBox_Show(pictureBox10, 9);
            pictureBox_Show(pictureBox17, 9);
            pictureBox_Show(pictureBox18, 9);
            pictureBox_Show(pictureBox24, 9);
            pictureBox_Show(pictureBox25, 9);
            pictureBox_Show(pictureBox12, 8);
            pictureBox_Show(pictureBox14, 8);
            pictureBox_Show(pictureBox16, 8);
            pictureBox_Show(pictureBox19, 8);
            pictureBox_Show(pictureBox21, 8);
            pictureBox_Show(pictureBox23, 8);
            pictureBox_Show(pictureBox13, 11);
            pictureBox_Show(pictureBox22, 11);
            pictureBox_Show(pictureBox15, 10);
            pictureBox_Show(pictureBox20, 10);


            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 8);
                pictureBox_Show(pictureBoxes[i], numbers[i]);
            }

            if (numbers[0] == numbers[1] && numbers[1] == numbers[2])
            {
                lines++;
                pictureBox_Show(pictureBox10, 13);
                pictureBox_Show(pictureBox11, 13);
            }
            if (numbers[3] == numbers[4] && numbers[4] == numbers[5])
            {
                lines++;
                pictureBox_Show(pictureBox17, 13);
                pictureBox_Show(pictureBox18, 13);
            }
            if (numbers[6] == numbers[7] && numbers[7] == numbers[8])
            {
                lines++;
                pictureBox_Show(pictureBox24, 13);
                pictureBox_Show(pictureBox25, 13);
            }
            if (numbers[0] == numbers[3] && numbers[3] == numbers[6])
            {
                lines++;
                pictureBox_Show(pictureBox12, 12);
                pictureBox_Show(pictureBox19, 12);
            }
            if (numbers[1] == numbers[4] && numbers[4] == numbers[7])
            {
                lines++;
                pictureBox_Show(pictureBox14, 12);
                pictureBox_Show(pictureBox21, 12);
            }
            if (numbers[2] == numbers[5] && numbers[5] == numbers[8])
            {
                lines++;
                pictureBox_Show(pictureBox16, 12);
                pictureBox_Show(pictureBox23, 12);
            }
            if (numbers[0] == numbers[4] && numbers[4] == numbers[8])
            {
                lines++;
                pictureBox_Show(pictureBox13, 15);
                pictureBox_Show(pictureBox22, 15);
            }
            if (numbers[2] == numbers[4] && numbers[4] == numbers[6])
            {
                lines++;
                pictureBox_Show(pictureBox15, 14);
                pictureBox_Show(pictureBox20, 14);
            }

            switch (lines)
            {
                case 1:
                    textBox1.Text = "100";
                    break;
                case 2:
                    textBox1.Text = "300";
                    break;
                case 3:
                    textBox1.Text = "1000";
                    break;
                case 4:
                    textBox1.Text = "5000";
                    break;
                case 5:
                    textBox1.Text = "20000";
                    break;
                case 6:
                    textBox1.Text = "50000";
                    break;
                case 7:
                    textBox1.Text = "200000";
                    break;
                case 8:
                    textBox1.Text = "2000000";
                    break;
                default:
                    textBox1.Text = "0";
                    break;
            }
        }

        private void pictureBox_Show(PictureBox pictureBox, int num)
        {
            switch (num)
            {
                case 1:
                    pictureBox.Image = Properties.Resources._1;
                    break;
                case 2:
                    pictureBox.Image = Properties.Resources._2;
                    break;
                case 3:
                    pictureBox.Image = Properties.Resources._3;
                    break;
                case 4:
                    pictureBox.Image = Properties.Resources._4;
                    break;
                case 5:
                    pictureBox.Image = Properties.Resources._5;
                    break;
                case 6:
                    pictureBox.Image = Properties.Resources._6;
                    break;
                case 7:
                    pictureBox.Image = Properties.Resources._7;
                    break;
                case 8:
                    pictureBox.Image = Properties.Resources.line_w1;
                    break;
                case 9:
                    pictureBox.Image = Properties.Resources.line_w2;
                    break;
                case 10:
                    pictureBox.Image = Properties.Resources.line_w3;
                    break;
                case 11:
                    pictureBox.Image = Properties.Resources.line_w4;
                    break;
                case 12:
                    pictureBox.Image = Properties.Resources.line_y1;
                    break;
                case 13:
                    pictureBox.Image = Properties.Resources.line_y2;
                    break;
                case 14:
                    pictureBox.Image = Properties.Resources.line_y3;
                    break;
                case 15:
                    pictureBox.Image = Properties.Resources.line_y4;
                    break;
                default:
                    break;
            }
        }
    }
}