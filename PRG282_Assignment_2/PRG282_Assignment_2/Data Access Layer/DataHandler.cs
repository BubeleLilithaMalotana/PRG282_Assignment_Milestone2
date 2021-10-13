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

        public DataHandler() 
        {

        }

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

            string query = "SELECT * FROM studentInformation";
            string query2 = "SELECT * FROM moduleInformation";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

       /* public DataTable SearchStudent(int studentNr)
        {
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not connected!");
            }

            string query = $"SELECT * FROM studentInformation WHERE StudentNumber = {studentNr}";
        }*/
    }
}
