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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Business_Logic_Layer.LoginFileHandler fileHandler = new Business_Logic_Layer.LoginFileHandler();

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterAccount frm3 = new RegisterAccount();
            frm3.Show();
            this.Hide();
         
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            fileHandler.login(txtLUsername.Text,txtLPassword.Text);
        }

        
    }
}
