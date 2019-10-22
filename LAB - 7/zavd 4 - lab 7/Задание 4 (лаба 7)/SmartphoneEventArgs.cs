using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_4__лаба_7_
{
    class SmartphoneEventArgs
    {
        public string Message { get; set; }

        public SmartphoneEventArgs(string message)
        {
            Message = message;
        }
    }
}
