namespace Week10_04
{
    public partial class Form1 : Form
    {

        private int tickCount;

        public Form1()
        {
            InitializeComponent();
            tickCount = 0;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tickCount++;
            label1.Text = tickCount.ToString();
        }
    }
}