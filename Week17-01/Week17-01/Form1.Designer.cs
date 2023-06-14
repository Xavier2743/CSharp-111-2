namespace Week17_01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeView1 = new TreeView();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 12);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(370, 426);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // button1
            // 
            button1.Location = new Point(399, 58);
            button1.Name = "button1";
            button1.Size = new Size(205, 23);
            button1.TabIndex = 1;
            button1.Text = "Add a node";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(399, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 23);
            textBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(399, 104);
            button2.Name = "button2";
            button2.Size = new Size(205, 23);
            button2.TabIndex = 3;
            button2.Text = "Add a node without selection";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(399, 150);
            button3.Name = "button3";
            button3.Size = new Size(205, 23);
            button3.TabIndex = 4;
            button3.Text = "Remove the selected node";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(399, 196);
            button4.Name = "button4";
            button4.Size = new Size(205, 23);
            button4.TabIndex = 5;
            button4.Text = "Clear node";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(628, 15);
            label1.Name = "label1";
            label1.Size = new Size(175, 15);
            label1.TabIndex = 6;
            label1.Text = "The content of the elected node";
            // 
            // button5
            // 
            button5.Location = new Point(399, 243);
            button5.Name = "button5";
            button5.Size = new Size(205, 23);
            button5.TabIndex = 7;
            button5.Text = "Edit node content";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 450);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Button button5;
    }
}