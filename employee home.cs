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
    public partial class employee_home : Form
    {
        String employeeID;

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

        public employee_home(string employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
        }

        private void employee_home_Load(object sender, EventArgs e)
        {
            Connect_DB();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT e_id,name,gender,b_group,phone,dob,email,salary FROM Employee WHERE e_id = '" + employeeID + "'";

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            textBox9.Text = reader.GetString(0);
            textBox1.Text = reader.GetString(1);
            textBox2.Text = reader.GetString(2);
            textBox5.Text = reader.GetString(3);
            textBox3.Text = reader.GetString(4);
            textBox4.Text = reader.GetString(5);
            textBox6.Text = reader.GetString(6);
            textBox7.Text = reader.GetString(7);
            //add department somehow

            reader.Close();
            cmd.Dispose();
            conn.Close();
        }

        private void patient_history_bt_Click(object sender, EventArgs e)
        {
            Inventory_Details frm = new Inventory_Details(employeeID);
            frm.Show();
        }
    }
}
