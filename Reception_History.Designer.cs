namespace HMS
{
    partial class Reception_History
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
            edit_bt = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Book Antiqua", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(203, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(313, 45);
            label1.TabIndex = 22;
            label1.Text = "Reception History";
            // 
            // ViewGrid_bt
            // 
            ViewGrid_bt.Location = new Point(43, 660);
            ViewGrid_bt.Margin = new Padding(2);
            ViewGrid_bt.Name = "ViewGrid_bt";
            ViewGrid_bt.Size = new Size(161, 38);
            ViewGrid_bt.TabIndex = 21;
            ViewGrid_bt.Text = "View";
            ViewGrid_bt.UseVisualStyleBackColor = true;
            ViewGrid_bt.Click += ViewGrid_bt_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 94);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(644, 539);
            dataGridView1.TabIndex = 20;
            // 
            // edit_bt
            // 
            edit_bt.Location = new Point(231, 660);
            edit_bt.Margin = new Padding(2);
            edit_bt.Name = "edit_bt";
            edit_bt.Size = new Size(161, 38);
            edit_bt.TabIndex = 23;
            edit_bt.Text = "Edit";
            edit_bt.UseVisualStyleBackColor = true;
            edit_bt.Click += edit_bt_Click;
            // 
            // Reception_History
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background_image;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(731, 730);
            Controls.Add(edit_bt);
            Controls.Add(label1);
            Controls.Add(ViewGrid_bt);
            Controls.Add(dataGridView1);
            Name = "Reception_History";
            Text = "Reception_History";
            Load += Reception_History_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button ViewGrid_bt;
        private DataGridView dataGridView1;
        private Button edit_bt;
    }
}