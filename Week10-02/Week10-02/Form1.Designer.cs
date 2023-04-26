namespace Week10_02
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
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox3 = new GroupBox();
            radioButton9 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(44, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 273);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Main";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(29, 195);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(101, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Egg Mcmuffin";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(29, 138);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(106, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Spicy McCrispy";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(29, 81);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(68, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Big Mac";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Location = new Point(262, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 273);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Side Dish";
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(53, 193);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(94, 19);
            radioButton6.TabIndex = 2;
            radioButton6.TabStop = true;
            radioButton6.Text = "radioButton6";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(53, 137);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(94, 19);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "radioButton5";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(53, 81);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(88, 19);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "French Fries";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton9);
            groupBox3.Controls.Add(radioButton8);
            groupBox3.Controls.Add(radioButton7);
            groupBox3.Location = new Point(480, 60);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 273);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Drink";
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(53, 193);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(54, 19);
            radioButton9.TabIndex = 2;
            radioButton9.TabStop = true;
            radioButton9.Text = "Fanta";
            radioButton9.UseVisualStyleBackColor = true;
            radioButton9.CheckedChanged += radioButton9_CheckedChanged;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(53, 137);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(73, 19);
            radioButton8.TabIndex = 1;
            radioButton8.TabStop = true;
            radioButton8.Text = "Black Tea";
            radioButton8.UseVisualStyleBackColor = true;
            radioButton8.CheckedChanged += radioButton8_CheckedChanged;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(53, 81);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(52, 19);
            radioButton7.TabIndex = 0;
            radioButton7.TabStop = true;
            radioButton7.Text = "Coke";
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += radioButton7_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 359);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 359);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(480, 359);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private GroupBox groupBox3;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}