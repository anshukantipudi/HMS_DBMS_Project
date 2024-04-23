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
        public patient_homepage(string patient_id)
        {
            InitializeComponent();
            this.patient_id = patient_id;
        }

        private void patient_homepage_Load(object sender, EventArgs e)
        {

        }
    }
}
