namespace Week16_01
{
    public partial class Form1 : Form
    {
        Boolean shouldPrint = false;
        int brushSize = 25;
        Color brushColor = Color.White;

        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Value = brushSize;
            comboBox1.Items.Add("White");
            comboBox1.Items.Add("Red");
            comboBox1.Items.Add("Blue");
            comboBox1.Items.Add("Green");
            comboBox1.Items.Add("Yellow");
            comboBox1.Items.Add("Black");
            comboBox1.SelectedIndex = 0;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            shouldPrint = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (shouldPrint)
            {
                using (Graphics graphics = CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(brushColor), e.X, e.Y, brushSize, brushSize);
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            shouldPrint = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 10;
            numericUpDown1.Maximum = 100;
            brushSize = (int)numericUpDown1.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    brushColor = Color.White;
                    break;
                case 1:
                    brushColor = Color.Red;
                    break;
                case 2:
                    brushColor = Color.Blue;
                    break;
                case 3:
                    brushColor = Color.Green;
                    break;
                case 4:
                    brushColor = Color.Yellow;
                    break;
                case 5:
                    brushColor = Color.Black;
                    break;
                default:
                    brushColor = Color.White;
                    break;
            }
        }
    }
}