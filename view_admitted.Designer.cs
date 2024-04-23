namespace HMS
{
    partial class view_admitted
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
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ViewGrid_bt
            // 
            ViewGrid_bt.Location = new Point(41, 639);
            ViewGrid_bt.Margin = new Padding(2);
            ViewGrid_bt.Name = "ViewGrid_bt";
            ViewGrid_bt.Size = new Size(161, 38);
            ViewGrid_bt.TabIndex = 19;
            ViewGrid_bt.Text = "View";
            ViewGrid_bt.UseVisualStyleBackColor = true;
            ViewGrid_bt.Click += ViewGrid_bt_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 79);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(644, 539);
            dataGridView1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Book Antiqua", 12F);
            label2.Location = new Point(41, 46);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(215, 28);
            label2.TabIndex = 20;
            label2.Text = "Admitted Patients:";
            // 
            // view_admitted
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background_image;
            ClientSize = new Size(722, 712);
            Controls.Add(label2);
            Controls.Add(ViewGrid_bt);
            Controls.Add(dataGridView1);
            Margin = new Padding(4);
            Name = "view_admitted";
            Text = "view_admitted";
            Load += view_admitted_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ViewGrid_bt;
        private DataGridView dataGridView1;
        private Label label2;
    }
}