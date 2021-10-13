using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Assignment_2.Data_Access_Layer
{
    class DataHandling
    {
        public void Login()
        {
            try
            {
                // checking if the student login details are saved in a txt file
                if (txtLUsername.Text.Contains(Students[0]) && txtLPassword.Text.Contains(Students[1]))
                {
                    MangementMenu frm2 = new MangementMenu();
                    this.Hide();
                    frm2.Show();
                }
                // Using Exceptional Handling to inform the user that the username or password are incorrect
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

        public void Register()
        {
            string username = txtRUsername.Text;
            string password = txtRPassword.Text;
            string ConfirmPassword = txtRConfirmPass.Text;

            try
            {
                // Using Exceptional Handling to ensure all text boxes are filled
                if (txtRUsername.Text == string.Empty || password == string.Empty || ConfirmPassword == string.Empty)
                {
                    throw new InvalidNameException("PLease ensure all options are filled in!");
                }

                // If all text boxes are filled in correctly then it registers the user
                if (password == ConfirmPassword && username != string.Empty)
                {
                    if (!students.Contains(username))
                    {
                        students.Add(username);
                        students.Add(password);
                        MessageBox.Show("Registration was successful!");
                        Login frm1 = new Login(students);
                        frm1.Show();
                        this.Hide();
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
    }
}
