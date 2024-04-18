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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("DC"))
            {
                Form5 frm = new Form5();
                frm.Show();
            }
            else if (textBox1.Text.Contains("EM"))
            {
                Form1 frmm = new Form1();
                frmm.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
