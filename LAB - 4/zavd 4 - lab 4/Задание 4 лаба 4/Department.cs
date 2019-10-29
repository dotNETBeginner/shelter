using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_4_лаба_4
{
    class Department
    {
        private string nameOfDepartment;

        public int numberOfRooms;

        public string NameOfDepartment
        {
            get { return nameOfDepartment; }
            set
            {
                if (value.Length < 1 || value.Length > 100)
                { Console.WriteLine("Invalid name of department!"); }
                else { nameOfDepartment = value; }
            }
        }

        public List<Room> someRooms = new List<Room>();

        public Department(string name)
        {
            NameOfDepartment = name;
            numberOfRooms = 0;

            for (int i = 0; i < 20; i++)
            { Room t = new Room(); someRooms.Add(t); }
        }
        public void addPatientInRoom(string patient)
        {
            if (numberOfRooms == 20)
            { Console.WriteLine("Sorry but all rooms is full!"); }
            else
            {

                if (someRooms[numberOfRooms].counter == 3)
                { numberOfRooms++; }

                someRooms[numberOfRooms].AddPatient(patient);

            }
        }
    }

}