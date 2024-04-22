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
    public partial class Admin_home : Form
    {
        public Admin_home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register_employee frm = new Register_employee();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Execute_Queries frm = new Execute_Queries();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            view_tables frm = new view_tables();
            frm.Show();
        }
    }
}
