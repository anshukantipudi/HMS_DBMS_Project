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
    public partial class Form5 : Form
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

        public Form5(String emp_id)
        {
            InitializeComponent();
            this.emp_id = emp_id;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Connect_DB();

            String AptQuery = "SELECT * FROM Appointment WHERE doctor_id = '" + emp_id + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(AptQuery, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            da.Dispose();
            ds.Dispose();

            String PatientQuery = "SELECT * FROM Prescription WHERE patient_id IN (SELECT patient_id FROM Appointment WHERE doctor_id = '" + emp_id + "')";
            MySqlDataAdapter da1 = new MySqlDataAdapter(PatientQuery, conn);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView2.DataSource = ds1.Tables[0];

            da1.Dispose();
            ds1.Dispose();

            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void write_bt_Click(object sender, EventArgs e)
        {
            Prescription frm = new Prescription(emp_id);
            frm.Show();
        }
    }
}
