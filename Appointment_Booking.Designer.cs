namespace HMS
{
    partial class Appointment_Booking
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            textBox1 = new TextBox();
            patient_combobox = new ComboBox();
            doctor_combobox = new ComboBox();
            apt_book_bt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Book Antiqua", 20F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(165, 9);
            label1.Name = "label1";
            label1.Size = new Size(415, 49);
            label1.TabIndex = 2;
            label1.Text = "Appointment Booking";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(32, 111);
            label2.Name = "label2";
            label2.Size = new Size(190, 32);
            label2.TabIndex = 3;
            label2.Text = "Appointment ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(33, 246);
            label3.Name = "label3";
            label3.Size = new Size(167, 32);
            label3.TabIndex = 4;
            label3.Text = "Assign Doctor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(32, 183);
            label4.Name = "label4";
            label4.Size = new Size(168, 32);
            label4.TabIndex = 5;
            label4.Text = "Assign Patient:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 11F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(254, 312);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(288, 37);
            dateTimePicker1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(32, 312);
            label5.Name = "label5";
            label5.Size = new Size(190, 32);
            label5.TabIndex = 7;
            label5.Text = "Appointment ID:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(254, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(288, 31);
            textBox1.TabIndex = 8;
            // 
            // patient_combobox
            // 
            patient_combobox.FormattingEnabled = true;
            patient_combobox.Location = new Point(254, 186);
            patient_combobox.Name = "patient_combobox";
            patient_combobox.Size = new Size(288, 33);
            patient_combobox.TabIndex = 9;
            // 
            // doctor_combobox
            // 
            doctor_combobox.FormattingEnabled = true;
            doctor_combobox.Location = new Point(254, 249);
            doctor_combobox.Name = "doctor_combobox";
            doctor_combobox.Size = new Size(288, 33);
            doctor_combobox.TabIndex = 10;
            // 
            // apt_book_bt
            // 
            apt_book_bt.Font = new Font("Segoe UI", 11F);
            apt_book_bt.Location = new Point(254, 383);
            apt_book_bt.Name = "apt_book_bt";
            apt_book_bt.Size = new Size(288, 41);
            apt_book_bt.TabIndex = 11;
            apt_book_bt.Text = "Book Appointment";
            apt_book_bt.UseVisualStyleBackColor = true;
            apt_book_bt.Click += apt_book_bt_Click;
            // 
            // Appointment_Booking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background_image;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(731, 730);
            Controls.Add(apt_book_bt);
            Controls.Add(doctor_combobox);
            Controls.Add(patient_combobox);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Appointment_Booking";
            Text = "Appointment_Booking";
            Load += Appointment_Booking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private TextBox textBox1;
        private ComboBox patient_combobox;
        private ComboBox doctor_combobox;
        private Button apt_book_bt;
    }
}