using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Assignment_2.Business_Logic_Layer
{
    class Students
    {
        int studentnumber { get; set; }
        string studentname { get; set; }
        string surname { get; set; }
        string dateofbirth { get; set; }
        string gender { get; set; }
        string phone { get; set; }
        string studentaddress { get; set; }
        string modulecode { get; set; }
        string modulename { get; set; }
        string moduledescription { get; set; }
        string link { get; set; }

        public Students(int studentNr, string studentName, string studentSurname, string dateOfBirth, string studentGender, string studentPhone, string studentAddress, string moduleCode, string moduleName, string moduleDescription, string moduleLink)
        {
            this.studentnumber = studentNr;
            this.studentname = studentName;
            this.surname = studentSurname;
            this.dateofbirth = dateOfBirth;
            this.gender = studentGender;
            this.phone = studentPhone;
            this.studentaddress = studentAddress;
            this.modulecode = moduleCode;
            this.modulename = moduleName;
            this.moduledescription = moduleDescription;
            this.link = moduleLink;
        }
    }
}
