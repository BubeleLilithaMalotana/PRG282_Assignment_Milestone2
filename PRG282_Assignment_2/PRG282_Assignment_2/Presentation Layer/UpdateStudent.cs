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
    public partial class UpdateStudent : Form
    {

        Data_Access_Layer.DataHandler handler = new Data_Access_Layer.DataHandler();

        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void txtUSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login frm1 = new Login();
            frm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MangementMenu frm2 = new MangementMenu();
            frm2.Show();
            this.Hide();

        }

        private void btnAddUphoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void btnUSearch_Click(object sender, EventArgs e)
        {
            handler.studentSearch(int.Parse(txtUSearch.Text));
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            handler.studentUpdate(int.Parse(txtRUsername.Text), textBox3.Text, textBox1.Text, comboBox1.Text, textBox5.Text, textBox7.Text, textBox4.Text, textBox2.Text, textBox8.Text, textBox6.Text);
        }
    }
}
