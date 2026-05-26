namespace _04
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Location = new Point(48, 47);
            button1.Name = "button1";
            button1.Size = new Size(112, 69);
            button1.TabIndex = 0;
            button1.Text = "開始遊戲";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Location = new Point(48, 137);
            button2.Name = "button2";
            button2.Size = new Size(112, 69);
            button2.TabIndex = 1;
            button2.Text = "看答案";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 270);
            label1.Name = "label1";
            label1.Size = new Size(46, 23);
            label1.TabIndex = 2;
            label1.Text = "輸入";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(61, 306);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Location = new Point(61, 353);
            button3.Name = "button3";
            button3.Size = new Size(112, 69);
            button3.TabIndex = 4;
            button3.Text = "檢查答案";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.Location = new Point(179, 353);
            button4.Name = "button4";
            button4.Size = new Size(112, 69);
            button4.TabIndex = 5;
            button4.Text = "放棄重來";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 47);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 6;
            label2.Text = "遊戲歷程";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(439, 91);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(278, 257);
            listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
        private Label label2;
        private ListBox listBox1;
    }
}
