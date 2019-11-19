using System;
using System.Collections.Generic;
using System.Text;

namespace задание_8_лаба_10
{
    class Room
    {
        public string RoomOwner { get; set; }

        public Room() { RoomOwner = "Room is Empty"; }

        public void AddOwner(string roomOwner) => RoomOwner = roomOwner;

        public void ReleaseOwner() => RoomOwner = "Room is Empty";
    }
}
