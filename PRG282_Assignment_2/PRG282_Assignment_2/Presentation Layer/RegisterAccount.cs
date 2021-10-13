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
    public partial class RegisterAccount : Form
    {
        Business_Logic_Layer.LoginFileHandler fileHandler = new Business_Logic_Layer.LoginFileHandler();
        public RegisterAccount()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fileHandler.register(txtRUsername.Text, txtRPassword.Text, txtRConfirmPass.Text);
        }
    }
}
