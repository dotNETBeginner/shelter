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
    }
}
