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
    public partial class nurse_home : Form
    {
        String e_id;
        public nurse_home(string e_id)
        {
            InitializeComponent();
            this.e_id = e_id;
        }

        private void nurse_home_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            view_admitted frm = new view_admitted();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            view_admitted_details frm = new view_admitted_details();
            frm.Show();
        }
    }
}
