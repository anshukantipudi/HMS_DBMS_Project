using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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

        public string ExtractTableName(string query)
        {
            // Regular expression pattern to match table names in SQL queries
            string pattern = @"\b(?:INSERT INTO|UPDATE|DELETE FROM)\s+([^\s]+)\b";

            Match match = Regex.Match(query, pattern, RegexOptions.IgnoreCase);

            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else
            {
                return "Unknown"; // If table name extraction fails
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
            conn.Close();
        }

        private void ViewGrid_bt_Click(object sender, EventArgs e)
        {
            Connect_DB();
            StringBuilder sb = new StringBuilder("");

            // Simulated user input (you would get this from your textbox)
            // For simplicity, I assume the user will provide a single query in this example

            String DataQuery = "";
            String QueryString = richTextBox1.Text;
            MySqlCommand cmd = new MySqlCommand(QueryString, conn);

            try
            {
                if (QueryString.StartsWith("INSERT") || QueryString.StartsWith("UPDATE") || QueryString.StartsWith("DELETE") || QueryString.StartsWith("insert") || QueryString.StartsWith("update") || QueryString.StartsWith("delete"))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        sb.Append(ExtractTableName(QueryString));
                        Console.WriteLine("The query was executed on table: " + sb.ToString());
                    }
                    else
                    {
                        Console.WriteLine("The query did not affect any rows.");
                    }

                    System.Threading.Thread.Sleep(1000);

                    DataQuery = "SELECT * FROM " + sb.ToString();
                }
                else
                {
                    DataQuery = QueryString;
                }

                MessageBox.Show("Query Successfully Run!");
                MySqlDataAdapter da = new MySqlDataAdapter(DataQuery, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            cmd.Dispose();
            conn.Close();
        }
    }
}
