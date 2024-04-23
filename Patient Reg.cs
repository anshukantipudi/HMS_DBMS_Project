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
    public partial class Form3 : Form
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
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            textBox8.Text = null;
            textBox9.Text = null;
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Connect_DB();
            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Connect_DB();

            int flag = 1;
            StringBuilder sb = new StringBuilder("");

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                flag = 0;
                MessageBox.Show("Name is a mandatory category");
            }
            else if (String.IsNullOrEmpty(textBox3.Text))
            {
                flag = 0;
                MessageBox.Show("Surname is a mandatory category");
            }
            else if (String.IsNullOrEmpty(textBox4.Text))
            {
                flag = 0;
                MessageBox.Show("Phone number is a mandatory category");
            }
            else if (String.IsNullOrEmpty(textBox5.Text))
            {
                flag = 0;
                MessageBox.Show("Email is a mandatory category");
            }
            else if (String.IsNullOrEmpty(textBox6.Text))
            {
                flag = 0;
                MessageBox.Show("Address is a mandatory category");
            }
            else if (String.IsNullOrEmpty(textBox7.Text))
            {
                flag = 0;
                MessageBox.Show("BGroup is a mandatory category");
            }
            else if (String.IsNullOrEmpty(textBox8.Text))
            {
                flag = 0;
                MessageBox.Show("Password is a mandatory category");
            }
            else if (String.IsNullOrEmpty(textBox9.Text))
            {
                flag = 0;
                MessageBox.Show("PatientID is a mandatory category");
            }

            if (radioButton1.Checked == true)
            {
                sb.Append(radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                sb.Append(radioButton2.Text);
            }
            else if (radioButton3.Checked == true)
            {
                sb.Append(radioButton3.Text);
            }
            else
            {
                flag = 0;
                MessageBox.Show("Gender is mandatory");
            }

            //SQL querying
            String datequery = "STR_TO_DATE('" + monthCalendar1.SelectionRange.Start.ToString("d") + "', '%d-%m-%Y')";

            String fullname = textBox1.Text +" "+ textBox2.Text +" "+ textBox3.Text;

            string InsertQuery = "INSERT INTO Patient(patient_id,password,name,gender,b_group,dob,email,phone,address) VALUES('" + textBox9.Text + "','" + textBox8.Text + "','" + fullname + "','" + sb.ToString() + "','" + textBox7.Text + "'," + datequery + ",'" + textBox5.Text + "'," + textBox4.Text + ",'" + textBox6.Text + "')";

            MySqlCommand command = new MySqlCommand(InsertQuery, conn);

            //Try Inserting
            if (flag == 1)
            {
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfully!");

                    System.Threading.Thread.Sleep(1000);
                    Clear_TB();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data Insert Failure!!");
                    MessageBox.Show(ex.Message);
                }
            }

            command.Dispose();
            conn.Close();
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
