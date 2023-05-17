namespace Week11_01
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[9];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            foreach (int i in numbers)
            {
                i = rnd.Next(1, 8);
            }


            pictureBox_Show(pictureBox1, num1);
            pictureBox_Show(pictureBox2, num2);
            pictureBox_Show(pictureBox3, num3);

            if (num1 * num2 * num3 % 343 == 0)
            {
                textBox1.Text = "10000";
            }
            else if (num1 * num2 * num3 % 49 == 0)
            {
                textBox1.Text = "1000";
            }
            else if (num1 * num2 * num3 % 7 == 0)
            {
                textBox1.Text = "100";
            }
            else
            {
                textBox1.Text = "You lose.";
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
                default:
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}