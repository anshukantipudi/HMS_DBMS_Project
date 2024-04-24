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
    public partial class view_admitted_details : Form
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

        public view_admitted_details()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void view_admitted_details_Load(object sender, EventArgs e)
        {
            Connect_DB();
            conn.Close();
        }

        private void ViewGrid_bt_Click(object sender, EventArgs e)
        {
            Connect_DB();

            String TestQuery = "SELECT * FROM Test NATURAL JOIN Takes";
            MySqlDataAdapter da1 = new MySqlDataAdapter(TestQuery, conn);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];

            da1.Dispose();
            ds1.Dispose();

            String MedQuery = "SELECT * FROM Med_Presc NATURAL JOIN Prescription";
            MySqlDataAdapter da = new MySqlDataAdapter(MedQuery, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

            da.Dispose();
            ds.Dispose();

            conn.Close();
        }
    }
}
