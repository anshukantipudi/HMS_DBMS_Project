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
    public partial class Admin_Login : Form
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

        public void Clear_TB()
        {
            textBox1.Text = null;
            textBox2.Text = null;
        }

        public Admin_Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" && textBox2.Text == "admin123")
            {
                Admin_home frm = new Admin_home();
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Admin Credentials Invalid!");
                Clear_TB();
            }
        }

        private void Admin_Login_Load(object sender, EventArgs e)
        {
            Connect_DB();
        }
    }
}
