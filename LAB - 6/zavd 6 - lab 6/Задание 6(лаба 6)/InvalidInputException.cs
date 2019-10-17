using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_6_лаба_6_
{
    class InvalidInputException : Exception
    {
        public InvalidInputException(string message)
            :base(message)
        {
        }
    }
}
