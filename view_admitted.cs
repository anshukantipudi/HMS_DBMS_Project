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
    public partial class view_admitted : Form
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

        public view_admitted()
        {
            InitializeComponent();
        }

        private void view_admitted_Load(object sender, EventArgs e)
        {
            Connect_DB();
            conn.Close();
        }

        private void ViewGrid_bt_Click(object sender, EventArgs e)
        {
            Connect_DB();

            String AptQuery = "SELECT patient_id,name,phone,room_no,doj,dol FROM Patient NATURAL JOIN Admitted";
            MySqlDataAdapter da = new MySqlDataAdapter(AptQuery, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            da.Dispose();
            ds.Dispose();
            conn.Close();
        }
    }
}
