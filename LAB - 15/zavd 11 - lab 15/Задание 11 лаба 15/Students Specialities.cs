using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_11_лаба_15
{
    class StudentsSpeciality
    {
        public string SpecialityName { get; set; }

        public string FacNum { get; set; }

        public StudentsSpeciality(string specialityName, string facNum)
        {
            SpecialityName = specialityName;
            FacNum = facNum;
        }
    }
}
