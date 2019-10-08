using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_9_лаба_3_
{
    class Rectangle
    {
        public string Id { get; set; }
        public int Widht { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Rectangle(string id, int width, int height, int x, int y)
        {
            Id = id;
            Widht = width;
            Height = height;
            X = x;
            Y = y;
        }
        
        public void findTouch(Rectangle rectangle)
        {
            int[] xyLeftLower1 = new int[2];//
            xyLeftLower1[0] = X;
            xyLeftLower1[1] = Y - Height; //Находим координаты левого нижнего угла

            int[] xyRightLower1 = new int[1];//
            xyRightLower1[0] = X + Widht;

            int[] xyRightUpper1 = new int[2];//
            xyRightUpper1[0] = xyRightLower1[0];
            xyRightUpper1[1] = Y;//Находим координаты парвого верхнего угла


            int[] xyLeftLower2 = new int[2];//
            xyLeftLower2[0] = rectangle.X;
            xyLeftLower2[1] = rectangle.Y - rectangle.Height; //Находим координаты левого нижнего угла второго треугольника

            int[] xyRightLower2 = new int[2];//
            xyRightLower2[0] = rectangle.X + rectangle.Widht;
            xyRightLower2[1] = rectangle.Y-rectangle.Height;//Находим координаты правого нижнего угла второго треугольника

            int[] xyRightUpper2 = new int[2];//
            xyRightUpper2[0] = xyRightLower2[0];
            xyRightUpper2[1] = rectangle.Y;//Находим координаты парвого верхнего угла второго треугольника 

            bool variant1 = false;
            bool variant2 = false;
            bool variant3 = false;
            bool variant4 = false;

            if (X >= rectangle.X && X <= xyRightUpper2[0])                                   
            {
                if (Y <= xyRightUpper2[1] && Y >= xyRightLower2[1]) { variant1 = true; }                        
            }

             if((Y <= rectangle.Y && Y >= xyLeftLower2[1]))
            {
                if((X >= rectangle.X && X <= xyRightLower2[0])) { variant2 = true; }
            }

             if(xyRightUpper1[0]<=xyRightUpper2[0]&&xyRightUpper1[0]>=rectangle.X)
            {
                if (xyRightUpper1[1] <= xyRightUpper2[1] && xyRightUpper1[1] >= xyRightLower2[1]) {variant3=true; }
            }

             if(xyLeftLower1[1]>=xyLeftLower2[1]&&xyLeftLower1[1]<=rectangle.Y)
            {
                if (xyLeftLower1[0] >= xyLeftLower2[0] && xyLeftLower1[0] <= xyRightLower2[0]) { variant4 = true;}
            }

            if(!variant1 && !variant2 && !variant3 && !variant4) {Console.WriteLine("/ ----------------------------------------------/\nДанные прямоугольники НЕ пересекаются!\n" +
                "----------------------------------------------/"); }
            else {Console.WriteLine("/----------------------------------------------/\nДанные прямоугольники пересекаются\n/----------------------------------------------/"); }          
        }

    }
}
