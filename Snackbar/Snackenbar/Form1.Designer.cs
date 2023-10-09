namespace Snackenbar
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
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            numericUpDown3 = new NumericUpDown();
            button1 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 48);
            label1.Name = "label1";
            label1.Size = new Size(284, 20);
            label1.TabIndex = 0;
            label1.Text = "How many packs of chips would you like?";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(58, 71);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(277, 27);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 117);
            label2.Name = "label2";
            label2.Size = new Size(236, 20);
            label2.TabIndex = 2;
            label2.Text = "How many donuts would you like?";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(58, 140);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(277, 27);
            numericUpDown2.TabIndex = 3;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 188);
            label3.Name = "label3";
            label3.Size = new Size(267, 20);
            label3.TabIndex = 4;
            label3.Text = "How many cans of soda would you like";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(58, 211);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(277, 27);
            numericUpDown3.TabIndex = 5;
            numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(58, 254);
            button1.Name = "button1";
            button1.Size = new Size(277, 47);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(numericUpDown3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 333);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(70, 351);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 96);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 58);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 1;
            label5.Text = "Total Revenue:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 23);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 0;
            label4.Text = "Current Order:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 459);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private Label label3;
        private NumericUpDown numericUpDown3;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
    }
}