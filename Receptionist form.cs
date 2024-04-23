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
    public partial class Form1 : Form
    {
        String e_id;
        public Form1(string e_id)
        {
            InitializeComponent();
            this.e_id = e_id;
        }

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

        private void Form1_Load(object sender, EventArgs e)
        {
            Connect_DB();
            conn.Close();
        }

        private void patient_reg_bt_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void bill_details_bt_Click(object sender, EventArgs e)
        {
            Reception_History frm = new Reception_History("Bill");
            frm.Show();
        }

        private void appt_bt_Click(object sender, EventArgs e)
        {
            Reception_History frm = new Reception_History("Appointment");
            frm.Show();
        }

        private void patient_history_bt_Click(object sender, EventArgs e)
        {
            Reception_History frm = new Reception_History("Patient");
            frm.Show();
        }

        private void emp_details_bt_Click(object sender, EventArgs e)
        {
            
        }

        private void inv_mgmt_bt_Click(object sender, EventArgs e)
        {
            
        }
    }
}
