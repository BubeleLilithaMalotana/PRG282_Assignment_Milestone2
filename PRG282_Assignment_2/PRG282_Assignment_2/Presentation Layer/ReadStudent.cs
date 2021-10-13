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
    public partial class ReadStudent : Form
    {
        //DataHandler handler = new DataHandler();
        
        public ReadStudent()
        {
            InitializeComponent();
        }

        private void ReadStudent_load(object sender, EventArgs e)
        {

            //dataGridView1.DataSource = handler.GetClients();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           MangementMenu frm2 = new MangementMenu();
            frm2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login frm1 = new Login();
            frm1.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = handler.SearchStudent(int.Parse(txtRUsername.Text));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];
                txtRUsername.Text = r.Cells["StudentNumber"].Value.ToString();
            }
        }
    }
}
