namespace HMS
{
    partial class test_history
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
            ViewGrid_bt = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Book Antiqua", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(246, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(221, 45);
            label1.TabIndex = 18;
            label1.Text = "Test History";
            // 
            // ViewGrid_bt
            // 
            ViewGrid_bt.Location = new Point(35, 630);
            ViewGrid_bt.Margin = new Padding(2);
            ViewGrid_bt.Name = "ViewGrid_bt";
            ViewGrid_bt.Size = new Size(161, 38);
            ViewGrid_bt.TabIndex = 17;
            ViewGrid_bt.Text = "View";
            ViewGrid_bt.UseVisualStyleBackColor = true;
            ViewGrid_bt.Click += ViewGrid_bt_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 70);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(644, 539);
            dataGridView1.TabIndex = 16;
            // 
            // test_history
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background_image;
            ClientSize = new Size(719, 700);
            Controls.Add(label1);
            Controls.Add(ViewGrid_bt);
            Controls.Add(dataGridView1);
            Margin = new Padding(4);
            Name = "test_history";
            Text = "test_history";
            Load += test_history_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button ViewGrid_bt;
        private DataGridView dataGridView1;
    }
}