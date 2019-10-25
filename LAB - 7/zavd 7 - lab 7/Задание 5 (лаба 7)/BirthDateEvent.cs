using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_5__лаба_7_
{
    delegate void forEvent(string yearDate);
    class BirthDateEvent
    {
        public event forEvent findYear;

        public void UserEvent(string yearDate)
        { findYear(yearDate); }
    }
}
