namespace Week16_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Save";
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Save As";
        }
    }
}