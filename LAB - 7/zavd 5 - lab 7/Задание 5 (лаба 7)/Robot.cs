using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_5__лаба_7_
{
    class Robot : IIdentifiable
    {
        public string Model { get; set; }
        public string Id { get; set; }

        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public void FindFakeId(string s)
        {
            int c = 0;
            for (int i = (Id.Length - 3); i < Id.Length; i++)
            {
                if (Id[i] == s[i - (Id.Length - 3)])
                { c++; }
            }
            if(c == 3) { Console.WriteLine(Id); }
        }
    }
}
