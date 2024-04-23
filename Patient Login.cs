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

        public void Clear_TB()
        {
            textBox1.Text = null;
            textBox2.Text = null;
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

            String LoginQuery_pid = "SELECT patient_id FROM Patient WHERE patient_id = '" + patient_id + "'";
            String LoginQuery_pwd = "SELECT password FROM Patient WHERE patient_id = '" + patient_id + "' AND password = '" + password + "'";

            using (var command = new MySqlCommand(LoginQuery_pid, conn))
            {
                try
                {
                    MySqlDataReader dr = command.ExecuteReader();
                    dr.Read();
                    if (dr.GetString(0) == patient_id)
                    {
                        pidcheck = 1;
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Patient ID!!!");
                    MessageBox.Show(ex.Message);
                }
            }

            if (pidcheck == 1)
            {
                using (var command = new MySqlCommand(LoginQuery_pwd, conn))
                {
                    try
                    {
                        MySqlDataReader dr = command.ExecuteReader();
                        dr.Read();
                        if(dr.GetString(0) == password)
                        {
                            pid_pwd_check = 1;
                        }
                        dr.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid Password!!!");
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            if (pid_pwd_check == 1)
            {
                Clear_TB();
                MessageBox.Show("Successfully logged in!");
                patient_homepage frm = new patient_homepage(patient_id);
                this.Hide();
                frm.Show();
            }

            conn.Close();
        }
    }
}
