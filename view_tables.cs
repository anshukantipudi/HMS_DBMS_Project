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
    public partial class view_tables : Form
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

        public view_tables()
        {
            InitializeComponent();
        }

        private void view_tables_Load(object sender, EventArgs e)
        {
            Connect_DB();

            // Query to retrieve all table names in the database
            string query = "SELECT table_name FROM information_schema.tables WHERE table_schema = @databaseName";

            using (var command = new MySqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@databaseName", conn.Database);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string tableName = reader.GetString("table_name");
                        //Console.WriteLine(tableName); DEBUG
                        comboBox1.Items.Add(tableName);
                    }
                }
            }

            conn.Close();
        }

        private void ViewGrid_bt_Click(object sender, EventArgs e)
        {
            Connect_DB();

            String ViewQuery = "SELECT * FROM " + comboBox1.Text;

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(ViewQuery, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
        }
    }
}
