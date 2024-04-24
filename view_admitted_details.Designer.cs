namespace HMS
{
    partial class view_admitted_details
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
            label2 = new Label();
            ViewGrid_bt = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Book Antiqua", 24F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(159, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 58);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Book Antiqua", 12F);
            label2.Location = new Point(35, 48);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 28);
            label2.TabIndex = 18;
            label2.Text = "Test Details:";
            label2.Click += label2_Click;
            // 
            // ViewGrid_bt
            // 
            ViewGrid_bt.Location = new Point(35, 614);
            ViewGrid_bt.Margin = new Padding(2);
            ViewGrid_bt.Name = "ViewGrid_bt";
            ViewGrid_bt.Size = new Size(161, 51);
            ViewGrid_bt.TabIndex = 17;
            ViewGrid_bt.Text = "View";
            ViewGrid_bt.UseVisualStyleBackColor = true;
            ViewGrid_bt.Click += ViewGrid_bt_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 80);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(644, 211);
            dataGridView1.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Book Antiqua", 12F);
            label3.Location = new Point(35, 331);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(227, 28);
            label3.TabIndex = 20;
            label3.Text = "Medication Details: ";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(35, 364);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(644, 211);
            dataGridView2.TabIndex = 19;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // view_admitted_details
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background_image;
            ClientSize = new Size(729, 730);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(label2);
            Controls.Add(ViewGrid_bt);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "view_admitted_details";
            Text = "view_admitted_details";
            Load += view_admitted_details_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button ViewGrid_bt;
        private DataGridView dataGridView1;
        private Label label3;
        private DataGridView dataGridView2;
    }
}