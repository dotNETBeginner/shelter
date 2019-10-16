using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_4_лаба_6_
{
    class InvalidSongNameException : Exception
    {
        public InvalidSongNameException(string message)
            :base(message)
        {
        }
    }
}
