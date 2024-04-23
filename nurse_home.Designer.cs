namespace HMS
{
    partial class nurse_home
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(238, 251);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(280, 69);
            button1.TabIndex = 3;
            button1.Text = "View admitted details";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Book Antiqua", 24F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(175, 54);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(386, 58);
            label1.TabIndex = 2;
            label1.Text = "Nurse Homepage";
            // 
            // button2
            // 
            button2.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(238, 151);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(280, 75);
            button2.TabIndex = 3;
            button2.Text = "View admitted patients";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // nurse_home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.Background_image;
            ClientSize = new Size(729, 730);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "nurse_home";
            Text = "nurse_home";
            Load += nurse_home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
    }
}