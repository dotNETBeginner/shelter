using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_11_лаба_15
{
    class Student
    {
        public string Name { get; set; }

        public string FacNum { get; set; }

        public Student(string facNum, string name)
        {
            FacNum = facNum;
            Name = name;
        }
    }
}
