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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void patient_reg_bt_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void bill_details_bt_Click(object sender, EventArgs e)
        {
            Billing_Details form = new Billing_Details();
            form.Show();
        }

        private void appt_bt_Click(object sender, EventArgs e)
        {
            Appointment_Details form = new Appointment_Details();
            form.Show();
        }

        private void patient_history_bt_Click(object sender, EventArgs e)
        {
            Patient_History form = new Patient_History();
            form.Show();
        }

        private void emp_details_bt_Click(object sender, EventArgs e)
        {
            Employee_Details form = new Employee_Details();
            form.Show();
        }

        private void inv_mgmt_bt_Click(object sender, EventArgs e)
        {
            
        }
    }
}
