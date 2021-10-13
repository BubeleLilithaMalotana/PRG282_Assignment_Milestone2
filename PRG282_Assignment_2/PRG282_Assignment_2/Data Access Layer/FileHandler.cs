using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRG282_Assignment_2.Data_Access_Layer
{
    class FileHandler
    {
        public void write(List<string> emp)
        {
            File.WriteAllLines("studentTxtFile.txt", emp);
        }
    }
}
