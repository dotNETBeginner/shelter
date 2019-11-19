using System;
using System.Collections.Generic;
using System.Text;

namespace задание_8_лаба_10
{
    class Clinic
    {
        public Room[] Rooms;

        private int numberOfRooms_;

        public string Name { get; set; }
        public int NumberOfRooms 
        { 
            get
            { return numberOfRooms_; }
            set
            { 
                if(value % 2 == 0)
                { 
                    throw new Exception("Invalid Operation! Number of rooms must be Odd");
                }
                else
                { numberOfRooms_ = value; }
            }
        }

        public Clinic(string name, int numberOfRooms)
        {
            Rooms = new Room[numberOfRooms];

            for(int i=0; i<Rooms.Length;i++)
            { Rooms[i] = new Room(); }

            Name = name;
            NumberOfRooms = numberOfRooms;
        }

        public bool Add(string petName, int petAge, string petKind)
        {
            int counter = 0;

            foreach (Room room in this.EnumForAdd())
            {
                if (room.RoomOwner == "Room is Empty")
                { room.AddOwner($"{petName} {petAge} {petKind}"); return true; }
                else
                { counter++; }           
            }

            if (counter == Rooms.Length)
            { return false; }
            else
            { return true; }
        }

        public bool Release()
        {
            foreach(Room room in this.EnumForRelease())
            {
                if(room.RoomOwner != "Room is Empty")
                { room.ReleaseOwner(); return true; }
            }

            return false;
        }

        public bool HasEmptyRooms()
        {
            for (int i = 0; i < Rooms.Length; i++)
            { 
                if(Rooms[i].RoomOwner == "Room is Empty")
                { return true; }
            }
            return false;
        }

        public void Print()
        {
            for(int i=0;i<Rooms.Length;i++)
            { Console.WriteLine(Rooms[i].RoomOwner); }
        }

        public void Print(int room)
        {
            Console.WriteLine(Rooms[room-1].RoomOwner);
        }

        public  IEnumerable<Room> EnumForAdd()
        {
            int n = Rooms.Length;
            int si1 = 0;
            int si2 = 1;

            if (Rooms.Length > 4)
            {
                for (int i = 0; i < Rooms.Length; i++)
                {
                    if (i == 0)
                    { yield return Rooms[n / 2]; }
                    else
                    {
                        if (i % 2 != 0)
                        { yield return Rooms[(n / 2) - i + si1]; si1++; }
                        else if (i % 2 == 0)
                        { yield return Rooms[(n / 2) + i - si2]; si2++; }
                    }
                }
            }
            else if(Rooms.Length == 1)
            { yield return Rooms[0]; }
            else if(Rooms.Length == 3)
            { 
                yield return Rooms[1];
                
                for(int i=0;i<Rooms.Length;i++)
                { if (i % 2 == 0) { yield return Rooms[i]; } }
            }
        }

        public IEnumerable<Room> EnumForRelease()
        {
            if(Rooms.Length > 4)
            {
                for(int i = (Rooms.Length/2); i < Rooms.Length; i++)
                { yield return Rooms[i]; }

                for (int i = 0; i < (Rooms.Length/2); i++)
                { yield return Rooms[i]; }
            }
            else if(Rooms.Length == 3)
            { 
                for(int i = 1; i < Rooms.Length; i++)
                { yield return Rooms[i]; }

                yield return Rooms[0];
            }
            else if(Rooms.Length == 1)
            { yield return Rooms[0]; }
        }
    }
}
