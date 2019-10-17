using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_6_лаба_6_
{
    class EmptyFieldException : Exception
    {
        public EmptyFieldException(string message)
            :base(message)
        {
        }
    }
}
