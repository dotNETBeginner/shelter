using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_4_лаба_6_
{
    class InvalidSongLenghtException : Exception
    {
        public InvalidSongLenghtException(string message)
            :base(message)
        {
        }
    }
}
