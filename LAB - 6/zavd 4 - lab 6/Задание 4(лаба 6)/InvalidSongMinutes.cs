using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_4_лаба_6_
{
    class InvalidSongMinutesException : Exception
    {
        public InvalidSongMinutesException(string message)
            :base(message)
        {
        }
    }
}
