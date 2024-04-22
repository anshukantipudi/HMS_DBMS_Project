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
            SuspendLayout();
            // 
            // appt_bt
            // 
            appt_bt.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            appt_bt.Location = new Point(307, 151);
            appt_bt.Margin = new Padding(2);
            appt_bt.Name = "appt_bt";
            appt_bt.Size = new Size(230, 41);
            appt_bt.TabIndex = 12;
            appt_bt.Text = "Appointment History";
            appt_bt.UseVisualStyleBackColor = true;
            // 
            // patient_history_bt
            // 
            patient_history_bt.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            patient_history_bt.Location = new Point(307, 218);
            patient_history_bt.Margin = new Padding(2);
            patient_history_bt.Name = "patient_history_bt";
            patient_history_bt.Size = new Size(230, 41);
            patient_history_bt.TabIndex = 11;
            patient_history_bt.Text = "Bill History";
            patient_history_bt.UseVisualStyleBackColor = true;
            // 
            // patient_reg_bt
            // 
            patient_reg_bt.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            patient_reg_bt.Location = new Point(44, 218);
            patient_reg_bt.Margin = new Padding(2);
            patient_reg_bt.Name = "patient_reg_bt";
            patient_reg_bt.Size = new Size(230, 41);
            patient_reg_bt.TabIndex = 10;
            patient_reg_bt.Text = "Prescription History";
            patient_reg_bt.UseVisualStyleBackColor = true;
            // 
            // bill_details_bt
            // 
            bill_details_bt.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            bill_details_bt.Location = new Point(44, 151);
            bill_details_bt.Margin = new Padding(2);
            bill_details_bt.Name = "bill_details_bt";
            bill_details_bt.Size = new Size(230, 41);
            bill_details_bt.TabIndex = 9;
            bill_details_bt.Text = "Patient Details";
            bill_details_bt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Book Antiqua", 24F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(204, 54);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(197, 49);
            label1.TabIndex = 8;
            label1.Text = "Welcome!";
            // 
            // patient_homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background_image;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(583, 584);
            Controls.Add(appt_bt);
            Controls.Add(patient_history_bt);
            Controls.Add(patient_reg_bt);
            Controls.Add(bill_details_bt);
            Controls.Add(label1);
            Name = "patient_homepage";
            Text = "patient_homepage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button appt_bt;
        private Button patient_history_bt;
        private Button patient_reg_bt;
        private Button bill_details_bt;
        private Label label1;
    }
}