﻿namespace HMS
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            monthCalendar1 = new MonthCalendar();
            label6 = new Label();
            label7 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label8 = new Label();
            textBox4 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            button1 = new Button();
            notifyIcon1 = new NotifyIcon(components);
            notifyIcon2 = new NotifyIcon(components);
            notifyIcon3 = new NotifyIcon(components);
            label11 = new Label();
            textBox7 = new TextBox();
            label12 = new Label();
            textBox8 = new TextBox();
            label13 = new Label();
            textBox9 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightBlue;
            label1.Font = new Font("Book Antiqua", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(155, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(391, 49);
            label1.TabIndex = 0;
            label1.Text = "Patient Registration";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 16F, FontStyle.Bold);
            label2.Location = new Point(14, 96);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(198, 32);
            label2.TabIndex = 1;
            label2.Text = "Patient Name: ";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 138);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 38);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(243, 138);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(197, 38);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(472, 138);
            textBox3.Margin = new Padding(2, 2, 2, 2);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(197, 38);
            textBox3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F);
            label3.Location = new Point(14, 177);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 19);
            label3.TabIndex = 5;
            label3.Text = "First Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F);
            label4.Location = new Point(243, 177);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 19);
            label4.TabIndex = 6;
            label4.Text = "Middle Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F);
            label5.Location = new Point(472, 177);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 7;
            label5.Text = "Surname";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(14, 367);
            monthCalendar1.Margin = new Padding(7, 7, 7, 7);
            monthCalendar1.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Book Antiqua", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 329);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(184, 32);
            label6.TabIndex = 9;
            label6.Text = "Date of Birth:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Book Antiqua", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(14, 225);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(116, 32);
            label7.TabIndex = 10;
            label7.Text = "Gender:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Book Antiqua", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(126, 227);
            radioButton1.Margin = new Padding(2, 2, 2, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(103, 31);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Female";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Book Antiqua", 13F);
            radioButton2.Location = new Point(228, 227);
            radioButton2.Margin = new Padding(2, 2, 2, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(82, 31);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "Male";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Book Antiqua", 13F);
            radioButton3.Location = new Point(310, 228);
            radioButton3.Margin = new Padding(2, 2, 2, 2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(90, 31);
            radioButton3.TabIndex = 13;
            radioButton3.TabStop = true;
            radioButton3.Text = "Other";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Book Antiqua", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(433, 194);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(213, 32);
            label8.TabIndex = 14;
            label8.Text = "Phone Number:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(434, 231);
            textBox4.Margin = new Padding(2, 2, 2, 2);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(235, 38);
            textBox4.TabIndex = 15;
            textBox4.TextChanged += textBox4_TextChanged_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Book Antiqua", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(311, 366);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(205, 32);
            label9.TabIndex = 16;
            label9.Text = "Email Address:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Book Antiqua", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(311, 263);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(125, 32);
            label10.TabIndex = 17;
            label10.Text = "Address:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(311, 400);
            textBox5.Margin = new Padding(2, 2, 2, 2);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(358, 38);
            textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(311, 306);
            textBox6.Margin = new Padding(2, 2, 2, 2);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(357, 59);
            textBox6.TabIndex = 19;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Book Antiqua", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ImageList = imageList1;
            button1.Location = new Point(433, 520);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(129, 47);
            button1.TabIndex = 20;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            notifyIcon2.Text = "notifyIcon2";
            notifyIcon2.Visible = true;
            // 
            // notifyIcon3
            // 
            notifyIcon3.Text = "notifyIcon3";
            notifyIcon3.Visible = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Book Antiqua", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(14, 282);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(121, 32);
            label11.TabIndex = 21;
            label11.Text = "BGroup:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(126, 288);
            textBox7.Margin = new Padding(2, 2, 2, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Book Antiqua", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(311, 439);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(141, 32);
            label12.TabIndex = 23;
            label12.Text = "Password:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(311, 473);
            textBox8.Margin = new Padding(2, 2, 2, 2);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(358, 38);
            textBox8.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Book Antiqua", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(14, 65);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(143, 32);
            label13.TabIndex = 25;
            label13.Text = "PatientID:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(155, 71);
            textBox9.Margin = new Padding(2, 2, 2, 2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 27);
            textBox9.TabIndex = 26;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(686, 584);
            Controls.Add(textBox9);
            Controls.Add(label13);
            Controls.Add(textBox8);
            Controls.Add(label12);
            Controls.Add(textBox7);
            Controls.Add(label11);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(monthCalendar1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private Label label5;
        private MonthCalendar monthCalendar1;
        private Label label6;
        private Label label7;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label8;
        private TextBox textBox4;
        private Label label9;
        private Label label10;
        private TextBox textBox5;
        private TextBox textBox6;
        private ImageList imageList1;
        private ImageList imageList2;
        protected internal Button button1;
        private NotifyIcon notifyIcon1;
        private NotifyIcon notifyIcon2;
        private NotifyIcon notifyIcon3;
        private Label label11;
        private TextBox textBox7;
        private Label label12;
        private TextBox textBox8;
        private Label label13;
        private TextBox textBox9;
    }
}