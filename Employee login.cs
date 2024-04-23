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

        public void Clear_TB()
        {
            textBox1.Text = null;
            textBox2.Text = null;
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

            String LoginQuery_eid = "SELECT e_id FROM Employee WHERE e_id = '" + employee_id + "'";
            String LoginQuery_pwd = "SELECT password FROM Employee WHERE e_id = '" + employee_id + "' AND password = '" + password + "'";

            using (var command = new MySqlCommand(LoginQuery_eid, conn))
            {
                try
                {
                    MySqlDataReader dr = command.ExecuteReader();
                    eidcheck = 1;
                    dr.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Invalid Employee ID!!!");
                    MessageBox.Show(ex.Message);
                }
            }

            if (eidcheck == 1)
            {
                using (var command = new MySqlCommand(LoginQuery_pwd, conn))
                {
                    try
                    {
                        MySqlDataReader dr = command.ExecuteReader();
                        eid_pwd_check = 1;
                        dr.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid Password!!!");
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            if (eid_pwd_check == 1)
            {
                Clear_TB();
                MessageBox.Show("Successfully logged in!");
                Form5 frm = new Form5(employee_id);
                //Link Employee form here
                this.Hide();
                frm.Show();
            }

            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
