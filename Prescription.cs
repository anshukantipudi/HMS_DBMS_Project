using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class Prescription : Form
    {
        String emp_id;

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
            apt_combobox.Text = null;
        }

        public Prescription(string emp_id)
        {
            InitializeComponent();
            this.emp_id = emp_id;
        }

        private void make_pr_bt_Click(object sender, EventArgs e)
        {
            Connect_DB();
            int flag = 1;

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                flag = 0;
                MessageBox.Show("Prescription ID is a mandatory category");
            }
            else if (String.IsNullOrEmpty(apt_combobox.Text))
            {
                flag = 0;
                MessageBox.Show("Appointment ID is a mandatory category");
            }
            else if (String.IsNullOrEmpty(textBox2.Text))
            {
                flag = 0;
                MessageBox.Show("Patient ID is a mandatory category");
            }
            else if (String.IsNullOrEmpty(remarkstb.Text))
            {
                flag = 0;
                MessageBox.Show("Remarks is compulsory!");
            }

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT patient_id FROM Appointment WHERE doctor_id = '"+ emp_id +"'";
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr.GetString(0);
            }
            dr.Close();
            cmd.Dispose();

            string InsertQuery = "INSERT INTO Prescription VALUES('"+ textBox1.Text +"','"+ apt_combobox.Text +"','"+ textBox2.Text +"','"+ remarkstb.Text +"')";

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

        private void Prescription_Load(object sender, EventArgs e)
        {
            Connect_DB();

            String EmpList = "SELECT app_id FROM Appointment WHERE doctor_id = '"+ emp_id +"'";
            using (var command = new MySqlCommand(EmpList, conn))
            {
                using (var reader = command.ExecuteReader())
                {
                    // Assuming comboBox1 is your ComboBox control
                    while (reader.Read())
                    {
                        apt_combobox.Items.Add(reader.GetString("app_id"));
                    }
                    reader.Close();
                }
                command.Dispose();
            }

            conn.Close();
        }
    }
}
