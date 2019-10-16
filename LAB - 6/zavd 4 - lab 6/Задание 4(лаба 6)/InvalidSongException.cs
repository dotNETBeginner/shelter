using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_4_лаба_6_
{
    class InvalidSongException : Exception
    {
        public InvalidSongException(string message)
            :base(message)
        {
        }
    }
}
