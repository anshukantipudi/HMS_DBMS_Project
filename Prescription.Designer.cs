namespace HMS
{
    partial class Prescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prescription));
            remarkstb = new RichTextBox();
            apt_combobox = new ComboBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            make_pr_bt = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // remarkstb
            // 
            remarkstb.Location = new Point(61, 362);
            remarkstb.Name = "remarkstb";
            remarkstb.Size = new Size(610, 150);
            remarkstb.TabIndex = 0;
            remarkstb.Text = "";
            // 
            // apt_combobox
            // 
            apt_combobox.FormattingEnabled = true;
            apt_combobox.Location = new Point(333, 223);
            apt_combobox.Name = "apt_combobox";
            apt_combobox.Size = new Size(288, 33);
            apt_combobox.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(283, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(288, 31);
            textBox1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(61, 220);
            label4.Name = "label4";
            label4.Size = new Size(247, 32);
            label4.TabIndex = 11;
            label4.Text = "Choose Appointment:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(61, 148);
            label2.Name = "label2";
            label2.Size = new Size(174, 32);
            label2.TabIndex = 10;
            label2.Text = "Prescription ID:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(283, 292);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(288, 31);
            textBox2.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(61, 289);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 14;
            label1.Text = "Patient ID:";
            // 
            // make_pr_bt
            // 
            make_pr_bt.Font = new Font("Segoe UI", 11F);
            make_pr_bt.Location = new Point(226, 535);
            make_pr_bt.Name = "make_pr_bt";
            make_pr_bt.Size = new Size(288, 41);
            make_pr_bt.TabIndex = 16;
            make_pr_bt.Text = "Finalise";
            make_pr_bt.UseVisualStyleBackColor = true;
            make_pr_bt.Click += make_pr_bt_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Book Antiqua", 20F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(156, 43);
            label3.Name = "label3";
            label3.Size = new Size(353, 49);
            label3.TabIndex = 17;
            label3.Text = "Make Prescription";
            // 
            // Prescription
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(731, 730);
            Controls.Add(label3);
            Controls.Add(make_pr_bt);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(apt_combobox);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(remarkstb);
            Name = "Prescription";
            Text = "Prescription";
            Load += Prescription_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox remarkstb;
        private ComboBox apt_combobox;
        private TextBox textBox1;
        private Label label4;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private Button make_pr_bt;
        private Label label3;
    }
}