using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace HMS
{
    public partial class Rec_Edit : Form
    {
        String Table;

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

        public Rec_Edit(string table)
        {
            InitializeComponent();
            this.Table = table;
        }

        private void Rec_Edit_Load(object sender, EventArgs e)
        {
            label1.Text = "Edit Table - "+ Table;
            textBox1.Text = "UPDATE INTO " + Table;

            Connect_DB();
            conn.Close();
        }

        private void ViewGrid_bt_Click(object sender, EventArgs e)
        {
            Connect_DB();
            StringBuilder sb = new StringBuilder("");

            // Simulated user input (you would get this from your textbox)
            // For simplicity, I assume the user will provide a single query in this example

            String DataQuery = "";
            String QueryString = textBox1.Text + richTextBox1.Text;
            MySqlCommand cmd = new MySqlCommand(QueryString, conn);

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("The query was executed on table: " + sb.ToString());
                }
                else
                {
                    Console.WriteLine("The query did not affect any rows.");
                }

                System.Threading.Thread.Sleep(1000);

                DataQuery = "SELECT * FROM " + Table;

                MessageBox.Show("Query Successfully Run!");
                MySqlDataAdapter da = new MySqlDataAdapter(DataQuery, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cmd.Dispose();
            conn.Close();
        }
    }
}
