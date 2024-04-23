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
    public partial class Form2 : Form
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

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Connect_DB();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connect_DB();
            String patient_id = textBox1.Text;
            String password = textBox2.Text;
            int pidcheck = 0;
            int pid_pwd_check = 0;

            String LoginQuery_pid = "SELECT patient_id FROM Patient WHERE patient_id = '"+patient_id+"'";
            String LoginQuery_pwd = "SELECT password FROM Patient WHERE patient_id = '" + patient_id + "' AND password = '"+ password +"'";
            
            using (var command = new MySqlCommand(LoginQuery_pid, conn))
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    pidcheck = 1;
                }
                else
                {
                    MessageBox.Show("Invalid Patient_ID!!!");
                }
            }

            if(pidcheck == 1)
            {
                using (var command = new MySqlCommand(LoginQuery_pwd, conn))
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        pid_pwd_check = 1;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password!!!");
                    }
                }
            }

            if (pid_pwd_check == 1)
            {
                MessageBox.Show("Successfully logged in!");
                //Link Patient form here
            }

            conn.Close();
        }
    }
}
