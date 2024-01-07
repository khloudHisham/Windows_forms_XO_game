namespace XO_Game
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            AImoves = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(28, 14);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 0;
            label1.Text = "Player wins-0";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(514, 9);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 1;
            label2.Text = "AI Wins – 0";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(60, 51);
            button1.Name = "button1";
            button1.Size = new Size(177, 160);
            button1.TabIndex = 2;
            button1.Tag = "play";
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += playerClick;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(243, 217);
            button2.Name = "button2";
            button2.Size = new Size(177, 160);
            button2.TabIndex = 3;
            button2.Tag = "play";
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += playerClick;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(60, 217);
            button3.Name = "button3";
            button3.Size = new Size(177, 160);
            button3.TabIndex = 4;
            button3.Tag = "play";
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += playerClick;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(426, 51);
            button4.Name = "button4";
            button4.Size = new Size(177, 160);
            button4.TabIndex = 5;
            button4.Tag = "play";
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += playerClick;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(243, 51);
            button5.Name = "button5";
            button5.Size = new Size(177, 160);
            button5.TabIndex = 6;
            button5.Tag = "play";
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += playerClick;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(60, 383);
            button6.Name = "button6";
            button6.Size = new Size(177, 160);
            button6.TabIndex = 7;
            button6.Tag = "play";
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            button6.Click += playerClick;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(426, 217);
            button7.Name = "button7";
            button7.Size = new Size(177, 160);
            button7.TabIndex = 8;
            button7.Tag = "play";
            button7.Text = "?";
            button7.UseVisualStyleBackColor = true;
            button7.Click += playerClick;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(243, 383);
            button8.Name = "button8";
            button8.Size = new Size(177, 160);
            button8.TabIndex = 9;
            button8.Tag = "play";
            button8.Text = "?";
            button8.UseVisualStyleBackColor = true;
            button8.Click += playerClick;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(426, 383);
            button9.Name = "button9";
            button9.Size = new Size(177, 160);
            button9.TabIndex = 10;
            button9.Tag = "play";
            button9.Text = "?";
            button9.UseVisualStyleBackColor = true;
            button9.Click += playerClick;
            // 
            // button10
            // 
            button10.Location = new Point(232, 555);
            button10.Name = "button10";
            button10.Size = new Size(173, 54);
            button10.TabIndex = 11;
            button10.Text = "Restart";
            button10.UseVisualStyleBackColor = true;
            button10.Click += restartGame;
            // 
            // AImoves
            // 
            AImoves.Interval = 1000;
            AImoves.Tick += AImove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 671);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "XO Game";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private System.Windows.Forms.Timer AImoves;
    }
}
