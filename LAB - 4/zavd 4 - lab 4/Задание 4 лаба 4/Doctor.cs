using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_4_лаба_4
{
    class Doctor
    {
        private string name;
        private string surname;

        public string Name 
        {
            get { return name; }
            set
            {
                if(value.Length < 1 || value.Length > 20)
                { Console.WriteLine("Invalid name!"); }
                else { name = value; }
            }
        }

        public string SurName
        {
            get { return surname; }
            set
            {
                if (value.Length < 1 || value.Length > 20)
                { Console.WriteLine("Invalid name!"); }
                else { surname = value; }
            }
        }

        public List<Patient> somePatients = new List<Patient>();

        public Doctor(string name, string surname, string patient) 
        {
            Name = name;
            SurName = surname;
            
             Patient t = new Patient(patient); somePatients.Add(t);
        }
          

        public void AddPatient(string patient)
        {
            bool exist = true;
            for(int i=0;i<somePatients.Count;i++)
            { 
                if (patient == somePatients[i].Name) 
                { exist = true; }
                else { exist = false; }
            }

            if (!exist)
            {
                    Patient t = new Patient(patient); somePatients.Add(t);
            }
            else { Console.WriteLine("Patient with this name is already exist"); }
        }
    }
}
