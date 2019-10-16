using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_4_лаба_6_
{
    class InvalidArtistNameException : Exception
    {
        public InvalidArtistNameException(string message)
            :base(message)
        {
        }
    }
}
