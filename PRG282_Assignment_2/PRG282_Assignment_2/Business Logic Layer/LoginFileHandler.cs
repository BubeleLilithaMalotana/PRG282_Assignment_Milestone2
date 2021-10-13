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
        public LoginFileHandler() { }

        public void register(string username, string pass1, string pass2)
        {
            List<string> users = new List<string>();
            List<string> pass = new List<string>();

            try
            {
                if (username == string.Empty || pass1 == string.Empty || pass2 == string.Empty)
                {
                    throw new InvalidNameException("PLease ensure all options are filled in!");     // Using Exceptional Handling to ensure all text boxes are filled
                }
                StreamReader sr = new StreamReader("LoginInfo.txt");
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    string[] components = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    users.Add(components[0]);
                    pass.Add(components[1]);

                }

                // If all text boxes are filled in correctly then it registers the user
                if (pass1 == pass2 && username != string.Empty)
                {
                    if (!users.Contains(username))
                    {

                        string myfile = @"LoginInfo.txt";
                        using (StreamWriter sw = File.AppendText(myfile))
                        {
                            sw.WriteLine(username + " " + pass1);
                        }
                        MangementMenu menu = new MangementMenu();
                        menu.Show();

                    }
                    else
                    {
                        MessageBox.Show("Sorry, This username has been taken!");
                    }
                }

                else
                {
                    throw new InvalidException("Password is not the same!");        // Using Exceptional Handling to inform the user that the Password and Confirm Password are not the same
                }
            }

            catch (InvalidNameException ex1)
            {
                MessageBox.Show(ex1.Message);
            }

            catch (InvalidException ex2)
            {
                MessageBox.Show(ex2.Message);
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
            try
            {
                if (users.Contains(username) && pass.Contains(password) && Array.IndexOf(users.ToArray(), username) == Array.IndexOf(pass.ToArray(), password))
                {
                    MangementMenu menu = new MangementMenu();
                    menu.Show();
                }
                else
                {
                    throw new InvalidPasswordException("Incorrect Username or Password, Try again!");
                }

            }
            catch (InvalidPasswordException ex1)
            {
                MessageBox.Show(ex1.Message);
            }


        }


    }
}

