using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_4_лаба_4
{
    class Patient 
    {
        private string name;
        public string Name 
        {
            get { return name; }
            set
            {
                if (value.Length < 1 || value.Length > 20)
                { Console.WriteLine("Invalid name!"); }
                else { name = value; }
            }
        }

        public Patient(string name) => Name = name;

        public Patient() { }
    }
}
