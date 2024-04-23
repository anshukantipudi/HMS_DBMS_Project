namespace HMS
{
    partial class Rec_Edit
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
            ViewGrid_bt = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ViewGrid_bt
            // 
            ViewGrid_bt.Font = new Font("Book Antiqua", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ViewGrid_bt.Location = new Point(507, 263);
            ViewGrid_bt.Margin = new Padding(2);
            ViewGrid_bt.Name = "ViewGrid_bt";
            ViewGrid_bt.Size = new Size(172, 46);
            ViewGrid_bt.TabIndex = 10;
            ViewGrid_bt.Text = "Execute";
            ViewGrid_bt.UseVisualStyleBackColor = true;
            ViewGrid_bt.Click += ViewGrid_bt_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(64, 335);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(615, 355);
            dataGridView1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Book Antiqua", 24F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(196, 40);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(247, 58);
            label1.TabIndex = 8;
            label1.Text = "Edit Table";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Book Antiqua", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 126);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(305, 35);
            label2.TabIndex = 7;
            label2.Text = "Enter Query (continue):";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(64, 215);
            richTextBox1.Margin = new Padding(4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(426, 94);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(426, 31);
            textBox1.TabIndex = 11;
            // 
            // Rec_Edit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background_image;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(731, 730);
            Controls.Add(textBox1);
            Controls.Add(ViewGrid_bt);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Name = "Rec_Edit";
            Text = "Rec_Edit";
            Load += Rec_Edit_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ViewGrid_bt;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
    }
}