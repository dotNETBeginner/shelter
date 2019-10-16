using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_4_лаба_6_
{
    class InvalidSongSecondsException : Exception
    {
        public InvalidSongSecondsException(string message)
            :base(message)
        {
        }
    }
}
