namespace HMS
{
    partial class Execute_Queries
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
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ViewGrid_bt = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(214, 118);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(314, 76);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Book Antiqua", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 138);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(149, 28);
            label2.TabIndex = 2;
            label2.Text = "Enter Query:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Book Antiqua", 24F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(149, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(306, 49);
            label1.TabIndex = 3;
            label1.Text = "Execute Queries";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 267);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(492, 284);
            dataGridView1.TabIndex = 4;
            // 
            // ViewGrid_bt
            // 
            ViewGrid_bt.Font = new Font("Book Antiqua", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ViewGrid_bt.Location = new Point(189, 206);
            ViewGrid_bt.Margin = new Padding(2);
            ViewGrid_bt.Name = "ViewGrid_bt";
            ViewGrid_bt.Size = new Size(138, 37);
            ViewGrid_bt.TabIndex = 5;
            ViewGrid_bt.Text = "Execute";
            ViewGrid_bt.UseVisualStyleBackColor = true;
            ViewGrid_bt.Click += ViewGrid_bt_Click;
            // 
            // Execute_Queries
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.Background_image;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(585, 584);
            Controls.Add(ViewGrid_bt);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Name = "Execute_Queries";
            Text = "Execute_Queries";
            Load += Execute_Queries_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button ViewGrid_bt;
    }
}