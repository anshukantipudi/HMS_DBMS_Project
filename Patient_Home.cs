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

namespace HMS
{
    public partial class Patient_Home : Form
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

        public void Clear_TB()
        {

        }

        public Patient_Home(string patient_id)
        {
            InitializeComponent();
            this.patient_id = patient_id;
        }

        private void Patient_Home_Load(object sender, EventArgs e)
        {
            Connect_DB();
            conn.Close();
        }
    }
}
