namespace Week08_01
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();
        FolderBrowserDialog fbd = new FolderBrowserDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = @"G:\Chrome";
            ofd.Title = "Select a file";
            ofd.Filter = "Image (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sfd.InitialDirectory = @"G:\Chrome";
            sfd.Title = "Save a file";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(sfd.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fbd.ShowDialog();
            textBox1.Text = fbd.SelectedPath;
        }
    }
}