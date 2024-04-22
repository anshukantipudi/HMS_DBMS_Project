namespace HMS
{
    partial class Admin_home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_home));
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Book Antiqua", 24F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(119, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(337, 49);
            label1.TabIndex = 1;
            label1.Text = "Admin Homepage";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Book Antiqua", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(61, 248);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(172, 39);
            button2.TabIndex = 3;
            button2.Text = "Execute Queries";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Book Antiqua", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(61, 170);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(172, 39);
            button1.TabIndex = 3;
            button1.Text = "Register patient";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Book Antiqua", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(307, 170);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(172, 39);
            button3.TabIndex = 3;
            button3.Text = "Register employee";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Book Antiqua", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(307, 248);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(172, 39);
            button4.TabIndex = 3;
            button4.Text = "View Tables";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Admin_home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(585, 584);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "Admin_home";
            Text = "Admin_home";
            Load += Admin_home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}