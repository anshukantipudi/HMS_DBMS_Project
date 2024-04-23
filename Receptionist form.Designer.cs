namespace HMS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            bill_details_bt = new Button();
            patient_reg_bt = new Button();
            patient_history_bt = new Button();
            appt_bt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Book Antiqua", 24F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(257, 43);
            label1.Name = "label1";
            label1.Size = new Size(235, 58);
            label1.TabIndex = 1;
            label1.Text = "Welcome!";
            // 
            // bill_details_bt
            // 
            bill_details_bt.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            bill_details_bt.Location = new Point(58, 133);
            bill_details_bt.Name = "bill_details_bt";
            bill_details_bt.Size = new Size(288, 51);
            bill_details_bt.TabIndex = 2;
            bill_details_bt.Text = "Billing Details";
            bill_details_bt.UseVisualStyleBackColor = true;
            bill_details_bt.Click += bill_details_bt_Click;
            // 
            // patient_reg_bt
            // 
            patient_reg_bt.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            patient_reg_bt.Location = new Point(58, 227);
            patient_reg_bt.Name = "patient_reg_bt";
            patient_reg_bt.Size = new Size(288, 51);
            patient_reg_bt.TabIndex = 3;
            patient_reg_bt.Text = "Patient Registration";
            patient_reg_bt.UseVisualStyleBackColor = true;
            patient_reg_bt.Click += patient_reg_bt_Click;
            // 
            // patient_history_bt
            // 
            patient_history_bt.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            patient_history_bt.Location = new Point(386, 227);
            patient_history_bt.Name = "patient_history_bt";
            patient_history_bt.Size = new Size(288, 51);
            patient_history_bt.TabIndex = 4;
            patient_history_bt.Text = "Patient Histroy ";
            patient_history_bt.UseVisualStyleBackColor = true;
            patient_history_bt.Click += patient_history_bt_Click;
            // 
            // appt_bt
            // 
            appt_bt.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            appt_bt.Location = new Point(386, 133);
            appt_bt.Name = "appt_bt";
            appt_bt.Size = new Size(288, 51);
            appt_bt.TabIndex = 5;
            appt_bt.Text = "Appointment History";
            appt_bt.UseVisualStyleBackColor = true;
            appt_bt.Click += appt_bt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(731, 730);
            Controls.Add(appt_bt);
            Controls.Add(patient_history_bt);
            Controls.Add(patient_reg_bt);
            Controls.Add(bill_details_bt);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bill_details_bt;
        private Button patient_reg_bt;
        private Button patient_history_bt;
        private Button appt_bt;
    }
}