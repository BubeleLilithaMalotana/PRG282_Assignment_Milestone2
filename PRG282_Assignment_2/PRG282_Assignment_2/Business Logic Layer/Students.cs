using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Assignment_2.Business_Logic_Layer
{
    class Students
    {
        string username { get; set; }
        string password { get; set; }

        public Students(string un, string pw)
        {
            this.username = un;
            this.password = pw;
        }

        public override string ToString()
        {
            return " Username: " + username + ", Password: " + password;
        }
    }
}
