using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRG282_Assignment_2.Data_Access_Layer
{
    class DataHandler
    {
        string conn = "Server=.; Initial Catalog= studentDB; Integrated Security=SSPI";

        public DataHandler() { }

        public DataTable GetStudent()
        {
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You are not connected to the database");
            }

            string query = "SELECT * FROM studentInformation" + "SELECT * FROM moduleInformation";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public void studentUpdate(int studentNr, string studentName, string studentSurname, string dateOfBirth, string studentGender, string studentPhone, string studentAddress, string moduleCode, string moduleName, string moduleDescription, string moduleLink)
        {
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();

            string commandSInfo = $"UPDATE studentInformation SET StudentNumber='{studentNr}', StudentName='{studentName}', Surname='{studentSurname}', DateOfBirth='{dateOfBirth}', Gender='{studentGender}', Phone='{studentPhone}', StudentAddress='{studentAddress}' " + $"UPDATE moduleInformation SET ModuleCode='{moduleCode}', ModuleName='{moduleName}', ModuleDescription='{moduleDescription}', Link='{moduleLink}'";
            
            SqlCommand commandA = new SqlCommand(commandSInfo, connection);

            try
            {
                commandA.ExecuteNonQuery();
                MessageBox.Show(studentName + " has been updated successfully");
            }

            catch (Exception ep1)
            {
                MessageBox.Show(ep1.Message);
            }

            finally
            {
                connection.Close();
            }
        }

        public DataTable  studentSearch(int studentNr)
        {
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                connection.Open();
            }

            catch (Exception)
            {
                MessageBox.Show("You are not connected to our SQLDatabase!");
            }

            string query = $"SELECT * FROM studentInformation WHERE StudentNumber = {studentNr}";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        public void studentDelete(int studentNr)
        {
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();

            string commandSDelete = $"DELETE studentInformation WHERE StudentNumber={studentNr}";

            try
            {
                if (MessageBox.Show("Student with Student Number " + studentNr, "DELETE", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand(commandSDelete, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show(studentNr + " has been deleted successfully");
                }
            }

            catch (Exception ep3)
            {
                MessageBox.Show(ep3.Message);
            }

            finally
            {
                connection.Close();
            }
        }
        public void studentAdd(int studentNr, string studentName, string studentSurname, string dateOfBirth, string studentGender, string studentPhone, string studentAddress, string moduleCode, string moduleName, string moduleDescription, string moduleLink)
        {
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();

            string commandAdd = $"INSERT INTO studentInformation VALUES('{studentNr}','{studentName}','{studentSurname}','{dateOfBirth}','{studentGender}','{studentPhone}', '{studentAddress}')" + $"INSERT INTO moduleInformation Values('{moduleCode}','{moduleName}','{moduleDescription}', '{moduleLink})";

            SqlCommand command = new SqlCommand(commandAdd, connection);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show(studentNr + " has been added successfully");
            }

            catch (Exception ep4)
            {
                MessageBox.Show(ep4.Message);
            }

            finally
            {
                connection.Close();
            }
        }
    }
}
