namespace Homework01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

        Random rnd = new Random();
        int[] prizes = { 100, 1000, 10000, 100000 };
        int total = 0;

        private void scratch(Label yourLabel, Label opponentLabel, Label prizeLabel, Button scratchButton)
        {
            int yourNumber = rnd.Next(20, 30);
            int opponentNumber;
            do
            {
                opponentNumber = rnd.Next(20, 30);
            } while (yourNumber == opponentNumber);
            int tempPrizeIndex = rnd.Next(100);
            int prizeIndex = 0;
            switch (tempPrizeIndex)
            {
                case < 75:
                    prizeIndex = 0;
                    break;
                case < 95:
                    prizeIndex = 1;
                    break;
                case < 99:
                    prizeIndex = 2;
                    break;
                case < 100:
                    prizeIndex = 3;
                    break;
            }

            yourLabel.Text = yourNumber.ToString();
            opponentLabel.Text = opponentNumber.ToString();
            prizeLabel.Text = prizes[prizeIndex].ToString();
            if (yourNumber > opponentNumber)
            {
                prizeLabel.ForeColor = Color.Red;
                total += prizes[prizeIndex];
            }
            else
            {
                prizeLabel.ForeColor = Color.Gray;
            }
            label4.Text = "Your total prize: " + total.ToString();
            label4.ForeColor = Color.Red;
            scratchButton.Enabled = false;
        }
    }
}