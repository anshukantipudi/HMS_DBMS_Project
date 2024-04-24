﻿using System;
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
    public partial class prescription_history : Form
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

        public prescription_history(String patient_id)
        {
            InitializeComponent();
            this.patient_id = patient_id;
        }

        private void prescription_history_Load(object sender, EventArgs e)
        {
            Connect_DB();
            conn.Close();
        }

        private void ViewGrid_bt_Click(object sender, EventArgs e)
        {
            Connect_DB();

            String AptQuery = "SELECT * FROM Prescription NATURAL JOIN test_presc NATURAL JOIN med_presc WHERE patient_id = '" + patient_id + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(AptQuery, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            da.Dispose();
            ds.Dispose();
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
