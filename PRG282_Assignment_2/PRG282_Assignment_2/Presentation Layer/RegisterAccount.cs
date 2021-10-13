using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PRG282_Assignment_2
{
    public partial class RegisterAccount : Form 
    {
        public RegisterAccount()
        {
            InitializeComponent();
        }
        Business_Logic_Layer.LoginFileHandler lfh = new Business_Logic_Layer.LoginFileHandler();

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                lfh.register(txtRUsername.Text,txtRPassword.Text,txtRConfirmPass.Text);
                MangementMenu frm2 = new MangementMenu();
                this.Hide();
                frm2.Show();
            }
            catch (Exception er)
            {
                MessageBox.Show("error" + er.Message);
            }


        }
    }
}
