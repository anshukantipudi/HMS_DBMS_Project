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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HMS
{
    public partial class Appointment_Booking : Form
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
            patient_combobox.Text = null;
            doctor_combobox.Text = null;
        }
        public Appointment_Booking()
        {
            InitializeComponent();
        }

        private void Appointment_Booking_Load(object sender, EventArgs e)
        {
            Connect_DB();

            String EmpList = "SELECT e_id FROM Doctor";
            using (var command = new MySqlCommand(EmpList, conn))
            {
                using (var reader = command.ExecuteReader())
                {
                    // Assuming comboBox1 is your ComboBox control
                    while (reader.Read())
                    {
                        doctor_combobox.Items.Add(reader.GetString("e_id"));
                    }
                    reader.Close();
                }
                command.Dispose();
            }

            String PatientList = "SELECT patient_id FROM Patient";
            using (var command = new MySqlCommand(PatientList, conn))
            {
                using (var reader = command.ExecuteReader())
                {
                    // Assuming comboBox1 is your ComboBox control
                    while (reader.Read())
                    {
                        patient_combobox.Items.Add(reader.GetString("patient_id"));
                    }
                    reader.Close();
                }
                command.Dispose();
            }

            conn.Close();
        }

        private void apt_book_bt_Click(object sender, EventArgs e)
        {
            Connect_DB();
            int flag = 1;

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                flag = 0;
                MessageBox.Show("Appointment ID is a mandatory category");
            }
            else if (String.IsNullOrEmpty(doctor_combobox.Text))
            {
                flag = 0;
                MessageBox.Show("Doctor ID is a mandatory category");
            }
            else if (String.IsNullOrEmpty(patient_combobox.Text))
            {
                flag = 0;
                MessageBox.Show("Patient ID is a mandatory category");
            }

            //SQL querying
            DateTime selected = dateTimePicker1.Value;
            DateTime date = selected.Date;
            TimeSpan time = selected.TimeOfDay;

            //String datequery = "STR_TO_DATE('" + date.ToString("d") + "', '%d-%m-%Y')";

            string InsertQuery = "INSERT INTO Appointment(app_id,doctor_id,patient_id,app_time,app_date) VALUES('"+textBox1.Text+"','"+doctor_combobox.Text+"','"+patient_combobox+"',"+time+","+date+")";

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
    }
}
