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

namespace PRG282_Assignment_2.Business_Logic_Layer
{
    class LoginFileHandler
    {
        public LoginFileHandler()
        {

        }
        
        public void register(string username, string pass1, string pass2)
        {
            if (username == null)
            {
                MessageBox.Show("Please enter a username");
            }
            else if (pass1 != pass2)
            {
                MessageBox.Show("The password do not match");

            }
            else
            {

                string myfile = @"LoginInfo.txt";

                using (StreamWriter sw = File.AppendText(myfile))
                {
                    sw.WriteLine(username + " " + pass1);
                }
               
            }
        }

        public void login(string username, string password)
        {

            List<string> users = new List<string>();
            List<string> pass = new List<string>();

            StreamReader sr = new StreamReader("LoginInfo.txt");
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] components = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                users.Add(components[0]);
                pass.Add(components[1]);

            }

            if (users.Contains(username) && pass.Contains(password) && Array.IndexOf(users.ToArray(), username) == Array.IndexOf(pass.ToArray(), password))
            {
                MangementMenu menu = new MangementMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("The Username and/or Password is incorect");
            }
        }

       
    }
}
