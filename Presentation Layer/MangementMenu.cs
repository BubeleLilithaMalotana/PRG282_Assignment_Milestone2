using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Assignment_2
{
    public partial class MangementMenu : Form
    {
        public MangementMenu()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login frm1 = new Login();
            frm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateStudent frm4 = new CreateStudent();
            frm4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadStudent frm3 = new ReadStudent();
            this.Hide();
            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateStudent frm5 = new UpdateStudent();
            frm5.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReadStudent frm3 = new ReadStudent();
            this.Hide();
            frm3.Show();
        }
    }
}
