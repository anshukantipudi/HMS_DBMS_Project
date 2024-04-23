namespace HMS
{
    partial class patient_homepage
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
            appt_bt = new Button();
            patient_history_bt = new Button();
            patient_reg_bt = new Button();
            bill_details_bt = new Button();
            label1 = new Label();
            textBox9 = new TextBox();
            label13 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // appt_bt
            // 
            appt_bt.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            appt_bt.Location = new Point(384, 189);
            appt_bt.Margin = new Padding(2);
            appt_bt.Name = "appt_bt";
            appt_bt.Size = new Size(288, 51);
            appt_bt.TabIndex = 12;
            appt_bt.Text = "Appointment History";
            appt_bt.UseVisualStyleBackColor = true;
            appt_bt.Click += appt_bt_Click;
            // 
            // patient_history_bt
            // 
            patient_history_bt.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            patient_history_bt.Location = new Point(384, 260);
            patient_history_bt.Margin = new Padding(2);
            patient_history_bt.Name = "patient_history_bt";
            patient_history_bt.Size = new Size(288, 51);
            patient_history_bt.TabIndex = 11;
            patient_history_bt.Text = "Bill History";
            patient_history_bt.UseVisualStyleBackColor = true;
            // 
            // patient_reg_bt
            // 
            patient_reg_bt.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            patient_reg_bt.Location = new Point(55, 260);
            patient_reg_bt.Margin = new Padding(2);
            patient_reg_bt.Name = "patient_reg_bt";
            patient_reg_bt.Size = new Size(288, 51);
            patient_reg_bt.TabIndex = 10;
            patient_reg_bt.Text = "Prescription History";
            patient_reg_bt.UseVisualStyleBackColor = true;
            patient_reg_bt.Click += patient_reg_bt_Click;
            // 
            // bill_details_bt
            // 
            bill_details_bt.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            bill_details_bt.Location = new Point(55, 189);
            bill_details_bt.Margin = new Padding(2);
            bill_details_bt.Name = "bill_details_bt";
            bill_details_bt.Size = new Size(288, 51);
            bill_details_bt.TabIndex = 9;
            bill_details_bt.Text = "Patient Details";
            bill_details_bt.UseVisualStyleBackColor = true;
            bill_details_bt.Click += bill_details_bt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Book Antiqua", 24F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(258, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(235, 58);
            label1.TabIndex = 8;
            label1.Text = "Welcome!";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(360, 88);
            textBox9.Margin = new Padding(2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(233, 31);
            textBox9.TabIndex = 57;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Book Antiqua", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(146, 85);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(169, 39);
            label13.TabIndex = 56;
            label13.Text = "PatientID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Book Antiqua", 16F, FontStyle.Bold);
            label2.Location = new Point(95, 124);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(233, 39);
            label2.TabIndex = 54;
            label2.Text = "Patient Name: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(360, 131);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 31);
            textBox1.TabIndex = 57;
            // 
            // button1
            // 
            button1.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            button1.Location = new Point(55, 335);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(288, 51);
            button1.TabIndex = 10;
            button1.Text = "Test History";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // patient_homepage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background_image;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(729, 730);
            Controls.Add(textBox1);
            Controls.Add(textBox9);
            Controls.Add(label13);
            Controls.Add(label2);
            Controls.Add(appt_bt);
            Controls.Add(patient_history_bt);
            Controls.Add(button1);
            Controls.Add(patient_reg_bt);
            Controls.Add(bill_details_bt);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "patient_homepage";
            Text = "patient_homepage";
            Load += patient_homepage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button appt_bt;
        private Button patient_history_bt;
        private Button patient_reg_bt;
        private Button bill_details_bt;
        private Label label1;
        private TextBox textBox9;
        private Label label13;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
    }
}