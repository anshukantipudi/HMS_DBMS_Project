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
    public partial class Form4 : Form
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

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Connect_DB();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connect_DB();
            String employee_id = textBox1.Text;
            String password = textBox2.Text;
            int eidcheck = 0;
            int eid_pwd_check = 0;

            String LoginQuery_pid = "SELECT patient_id FROM Patient WHERE patient_id = '" + employee_id + "'";
            String LoginQuery_pwd = "SELECT password FROM Patient WHERE patient_id = '" + employee_id + "' AND password = '" + password + "'";

            using (var command = new MySqlCommand(LoginQuery_pid, conn))
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    eidcheck = 1;
                }
                else
                {
                    MessageBox.Show("Invalid Employee_ID!!!");
                }
            }

            if (eidcheck == 1)
            {
                using (var command = new MySqlCommand(LoginQuery_pwd, conn))
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        eid_pwd_check = 1;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password!!!");
                    }
                }
            }

            if (eid_pwd_check == 1)
            {
                MessageBox.Show("Successfully logged in!");
                //Link Employee form here
            }

            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
