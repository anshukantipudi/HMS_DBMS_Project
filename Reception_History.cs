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
    public partial class Reception_History : Form
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

        public Reception_History(string table)
        {
            InitializeComponent();
            this.Table = table;
        }

        private void Reception_History_Load(object sender, EventArgs e)
        {
            label1.Text = Table + " History";
            Connect_DB();
            conn.Close();
        }

        private void ViewGrid_bt_Click(object sender, EventArgs e)
        {
            Connect_DB();
            String SupQuery = "SELECT * FROM " + Table;

            MySqlDataAdapter da = new MySqlDataAdapter(SupQuery, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            da.Dispose();
            ds.Dispose();
            conn.Close();
        }

        private void edit_bt_Click(object sender, EventArgs e)
        {
            Rec_Edit frm = new Rec_Edit(Table);
            frm.Show();
        }
    }
}
