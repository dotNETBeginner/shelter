using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_4_лаба_4
{
    class Room
    {

        public List<Patient> somePatients = new List<Patient>(); 

        public int counter = 0;

        private bool ifRoomIsFull;


        public Room() 
        {
            ifRoomIsFull = false;
        }


        public void AddPatient(string patient)
        {

            if (counter >= 3)
            { ifRoomIsFull = true; }

            if (!ifRoomIsFull)
            {
                Patient t = new Patient(patient);
                somePatients.Add(t);
                counter++;
            }
            else { Console.WriteLine("This room is full! But you can vizit another room!"); }

        }
    }
}
