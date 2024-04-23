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
    public partial class patient_details : Form
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

        public patient_details(string patient_id)
        {
            InitializeComponent();
            this.patient_id = patient_id;
        }

        private void patient_details_Load(object sender, EventArgs e)
        {
            Connect_DB();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT patient_id,name,gender,phone,b_group,dob,email,address FROM Patient WHERE patient_id = '"+ patient_id +"'";

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            textBox9.Text = reader.GetString(0);
            textBox1.Text = reader.GetString(1);
            textBox8.Text = reader.GetString(2);
            textBox11.Text = reader.GetValue(3).ToString();
            textBox7.Text = reader.GetString(4);
            textBox10.Text = reader.GetMySqlDateTime(5).ToString();
            textBox5.Text = reader.GetString(6);
            textBox6.Text = reader.GetString(7);

            reader.Close();
            cmd.Dispose();
            conn.Close();
        }
    }
}
