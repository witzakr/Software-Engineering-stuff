namespace Finances
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            CreateLottery = new Button();
            DrawNextNumber = new Button();
            ShowAll = new Button();
            listBox1 = new ListBox();
            Reset = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(309, 137);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lottery Settings";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(172, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 70);
            label2.Name = "label2";
            label2.Size = new Size(160, 20);
            label2.TabIndex = 1;
            label2.Text = "Nr of wanted numbers:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 38);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Max value:";
            // 
            // CreateLottery
            // 
            CreateLottery.Location = new Point(12, 193);
            CreateLottery.Name = "CreateLottery";
            CreateLottery.Size = new Size(309, 29);
            CreateLottery.TabIndex = 4;
            CreateLottery.Text = "Create a lottery object";
            CreateLottery.UseVisualStyleBackColor = true;
            CreateLottery.Click += CreateLottery_Click;
            // 
            // DrawNextNumber
            // 
            DrawNextNumber.Location = new Point(12, 228);
            DrawNextNumber.Name = "DrawNextNumber";
            DrawNextNumber.Size = new Size(309, 29);
            DrawNextNumber.TabIndex = 5;
            DrawNextNumber.Text = "Draw next number";
            DrawNextNumber.UseVisualStyleBackColor = true;
            DrawNextNumber.Click += DrawNextNumber_Click;
            // 
            // ShowAll
            // 
            ShowAll.Location = new Point(12, 263);
            ShowAll.Name = "ShowAll";
            ShowAll.Size = new Size(309, 29);
            ShowAll.TabIndex = 6;
            ShowAll.Text = "Show all drawn numbers";
            ShowAll.UseVisualStyleBackColor = true;
            ShowAll.Click += ShowAll_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(368, 31);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(248, 264);
            listBox1.TabIndex = 7;
            // 
            // Reset
            // 
            Reset.Location = new Point(368, 301);
            Reset.Name = "Reset";
            Reset.Size = new Size(248, 29);
            Reset.TabIndex = 8;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 357);
            Controls.Add(Reset);
            Controls.Add(listBox1);
            Controls.Add(CreateLottery);
            Controls.Add(ShowAll);
            Controls.Add(DrawNextNumber);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button CreateLottery;
        private Button DrawNextNumber;
        private Button ShowAll;
        private ListBox listBox1;
        private Button Reset;
    }
}