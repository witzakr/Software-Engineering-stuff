namespace FINANCES
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
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            listBox1 = new ListBox();
            button3 = new Button();
            groupBox2 = new GroupBox();
            button4 = new Button();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 225);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(73, 132);
            button1.Name = "button1";
            button1.Size = new Size(129, 68);
            button1.TabIndex = 1;
            button1.Text = "Add to the expenses log";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(86, 88);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(48, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 90);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 2;
            label2.Text = "Amount:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(96, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 40);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // button2
            // 
            button2.Location = new Point(12, 243);
            button2.Name = "button2";
            button2.Size = new Size(250, 29);
            button2.TabIndex = 1;
            button2.Text = "Show all expenses";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(308, 18);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(214, 384);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(308, 409);
            button3.Name = "button3";
            button3.Size = new Size(214, 29);
            button3.TabIndex = 3;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 291);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 147);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(6, 82);
            button4.Name = "button4";
            button4.Size = new Size(238, 59);
            button4.TabIndex = 2;
            button4.Text = "show expenses with the same amount";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(86, 39);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(100, 27);
            numericUpDown2.TabIndex = 1;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 41);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 0;
            label3.Text = "Amount:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(559, 450);
            Controls.Add(groupBox2);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private ListBox listBox1;
        private Button button3;
        private GroupBox groupBox2;
        private Button button4;
        private NumericUpDown numericUpDown2;
        private Label label3;
    }
}