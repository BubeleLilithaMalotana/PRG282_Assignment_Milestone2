using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Assignment_2.Business_Logic_Layer
{
    class InvalidNameException : Exception
    {

        public InvalidNameException()
        {

        }

        public InvalidNameException(string message) : base(message)
        {

        }

        public InvalidNameException(string message, Exception inner) : base(message, inner)
        {

        }
    }

    class InvalidException : Exception
    {
        public InvalidException()
        {

        }

        public InvalidException(string message) : base(message)
        {

        }

        public InvalidException(string message, Exception inner) : base(message, inner)
        {

        }
    }

    class InvalidPasswordException : Exception
    {
        public InvalidPasswordException()
        {

        }

        public InvalidPasswordException(string message) : base(message)
        {

        }

        public InvalidPasswordException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
