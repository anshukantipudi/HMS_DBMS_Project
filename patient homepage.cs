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
    public partial class patient_homepage : Form
    {
        String patient_id;

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

        public patient_homepage(string patient_id)
        {
            InitializeComponent();
            this.patient_id = patient_id;
        }

        private void patient_homepage_Load(object sender, EventArgs e)
        {
            Connect_DB();

            MySqlCommand command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT patient_id,name FROM Patient WHERE patient_id = '" + patient_id + "'";

            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            textBox9.Text = reader.GetString(0);
            textBox1.Text = reader.GetString(1);

            reader.Close();
            command.Dispose();
            conn.Close();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void bill_details_bt_Click(object sender, EventArgs e)
        {
            patient_details frm = new patient_details(patient_id);
            frm.Show();
        }

        private void appt_bt_Click(object sender, EventArgs e)
        {
            Appointment_Details frm = new Appointment_Details(patient_id);
            frm.Show();
        }

        private void patient_reg_bt_Click(object sender, EventArgs e)
        {
            prescription_history frm = new prescription_history(patient_id);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test_history frm = new test_history(patient_id);
            frm.Show();
        }

        private void patient_history_bt_Click(object sender, EventArgs e)
        {
            Billing_Details frm = new Billing_Details(patient_id);
            frm.Show();
        }
    }
}
