using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace HMS
{
    public partial class Execute_Queries : Form
    {
        //Connection string
        MySqlConnection conn = new MySqlConnection("SERVER=LOCALHOST;DATABASE=HMS;UID=root;PASSWORD=anshu;");

        public void Connect_DB()
        {
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Execute_Queries()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Execute_Queries_Load(object sender, EventArgs e)
        {
            Connect_DB();
        }

        private void ViewGrid_bt_Click(object sender, EventArgs e)
        {
            String QueryString = richTextBox1.Text;
            MySqlCommand cmd = new MySqlCommand(QueryString, conn);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Query Successfully Run!");

                System.Threading.Thread.Sleep(2000);

                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM ", conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            System.Threading.Thread.Sleep(3000);
            dataGridView1.Rows.Clear();
            richTextBox1.Text = null;
            cmd.Dispose();
            conn.Close();
        }
    }
}
