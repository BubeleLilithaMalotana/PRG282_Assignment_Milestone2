using System;
using System.Collections.Generic;
using System.Configuration;
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
        Data_Access_Layer.DataHandler handler = new Data_Access_Layer.DataHandler();
        
        public ReadStudent()
        {
            InitializeComponent();
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
           dataGridView1.DataSource = handler.studentSearch(int.Parse(txtRUsername.Text));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtRUsername.Text = row.Cells["StudentNumber"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            handler.studentDelete(int.Parse(txtRUsername.Text));
        }
    }
}
