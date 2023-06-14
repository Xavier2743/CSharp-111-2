namespace Week17_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode treenode = new TreeNode(textBox1.Text);
            treeView1.SelectedNode.Nodes.Add(treenode);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TreeNode treenode = new TreeNode(textBox1.Text);
            treeView1.Nodes.Add(treenode);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            label1.Text = treeView1.SelectedNode.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Text = textBox1.Text;
        }
    }
}