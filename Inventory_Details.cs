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
    public partial class Inventory_Details : Form
    {
        String emp_id;

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

        public Inventory_Details(string emp_id)
        {
            InitializeComponent();
            this.emp_id = emp_id;
        }

        private void Inventory_Details_Load(object sender, EventArgs e)
        {
            Connect_DB();
            conn.Close();
        }

        private void ViewGrid_bt_Click(object sender, EventArgs e)
        {
            Connect_DB();
            String SupQuery = "SELECT * FROM manage_supplies NATURAL JOIN supplies WHERE e_id = '"+ emp_id +"'";

            MySqlDataAdapter da = new MySqlDataAdapter(SupQuery, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            da.Dispose();
            ds.Dispose();
            conn.Close();
        }
    }
}
