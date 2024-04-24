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
    public partial class employee_home : Form
    {
        String employeeID;
        String Table = "";

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

        public employee_home(string employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
        }

        private void employee_home_Load(object sender, EventArgs e)
        {
            Connect_DB();

            // Sample emp_id to check
            string empIdToCheck = employeeID;

            // Check Nurse table
            string nurseQuery = "SELECT * FROM Employee e LEFT JOIN Nurse n ON e.e_id = n.e_id WHERE e.e_id = @empIdToCheck";
            bool isNurse = CheckTable(conn, nurseQuery, empIdToCheck);

            // Check Doctor table
            string doctorQuery = "SELECT * FROM Employee e LEFT JOIN Doctor d ON e.e_id = d.e_id WHERE e.e_id = @empIdToCheck";
            bool isDoctor = CheckTable(conn, doctorQuery, empIdToCheck);

            // Check Receptionist table
            string receptionistQuery = "SELECT * FROM Employee e LEFT JOIN Receptionist r ON e.e_id = r.e_id WHERE e.e_id = @empIdToCheck";
            bool isReceptionist = CheckTable(conn, receptionistQuery, empIdToCheck);

            // Check NonMedicalStaff table
            string nonMedicalStaffQuery = "SELECT * FROM Employee e LEFT JOIN Non_Med_Staff nms ON e.e_id = nms.e_id WHERE e.e_id = @empIdToCheck";
            bool isNonMedicalStaff = CheckTable(conn, nonMedicalStaffQuery, empIdToCheck);

            if (employeeID == "1008" || employeeID == "1009" || employeeID == "1010")
            {
                Table = "Nurse";
            }
            else if (employeeID == "1001" || employeeID == "1002" || employeeID == "1003")
            {
                Table = "Doctor";
            }
            else if (employeeID == "1004" || employeeID == "1005")
            {
                Table = "Receptionist";
            }
            else if (employeeID == "1006" || employeeID == "1007")
            {
                Table = "Non_Med_Staff";
            }

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT e_id,name,gender,b_group,phone,dob,email,salary FROM Employee WHERE e_id = '" + employeeID + "'";

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            textBox9.Text = reader.GetString(0);
            textBox1.Text = reader.GetString(1);
            textBox2.Text = reader.GetString(2);
            textBox5.Text = reader.GetString(3);
            textBox3.Text = reader.GetValue(4).ToString();
            textBox4.Text = reader.GetMySqlDateTime(5).ToString();
            textBox6.Text = reader.GetString(6);
            textBox7.Text = reader.GetValue(7).ToString();
            //added department somehow i'm too good bro

            reader.Close();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT dept_id FROM "+ Table +" WHERE e_id = '"+ employeeID +"'";
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) // Check if there is at least one row
            {
                textBox10.Text = dr.GetValue(0).ToString();
            }
            else
            {
                // Handle case where no rows were returned
                textBox10.Text = "No department found";
            }
            dr.Close();

            cmd.Dispose();
            conn.Close();
        }

        private void patient_history_bt_Click(object sender, EventArgs e)
        {
            Inventory_Details frm = new Inventory_Details(employeeID);
            frm.Show();
        }

        public bool CheckTable(MySqlConnection connection, string query, string empIdToCheck)
        {
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@empIdToCheck", empIdToCheck);
                using (var reader = command.ExecuteReader())
                {
                    return reader.Read(); // If reader has rows, emp_id is present in this table
                }
            }
        }

        private void advanced_bt_Click(object sender, EventArgs e)
        {
            if (Table == "Doctor")
            {
                Form5 frm = new Form5(employeeID);
                frm.Show();
            }
            else if (Table == "Nurse")
            {
                nurse_home frm = new nurse_home(employeeID);
                frm.Show();
            }
            else if (Table == "Receptionist")
            {
                Form1 frm = new Form1(employeeID);
                frm.Show();
            }
            else if(Table == "Non_Med_Staff")
            {
                MessageBox.Show("No Extra Functionality!");
            }

            //TODO: Doctor,Nurse,Rec Home forms
        }
    }
}
