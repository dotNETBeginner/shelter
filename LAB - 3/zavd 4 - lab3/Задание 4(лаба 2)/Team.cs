using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_4_лаба_2_
{
    class Team
    {
        Person[] man;

        public Team() { }

        public Team(int size)
        {
            man = new Person[size];
        }

        public void addMan(int i,string[] name,int[] age) { man[i] = new Person(name[i], age[i]);}

        public void printMan(int i) { Console.WriteLine($"{man[i].Name}  {man[i].Age}"); ; }

        public void findMoreThan30(int n, Team test)
        {
            int c = 0;

           for(int i=0;i<n;i++)
            {
                if (test.man[i].Age > 30) { c++; }
            }

            Person[] sort=new Person[c];

            int r = 0;
            for (int i = 0; i < n; i++)
            {
                if (test.man[i].Age > 30) { sort[r]=new Person();r++; }
            }

            r = 0;
            for (int i=0;i<n;i++)
            {
                if (test.man[i].Age > 30) { sort[r].Name= test.man[i].Name; sort[r].Age = test.man[i].Age; r++; }
            }

            int p = sort[0].Name.Length;
            for (int m = 0; m < n *(n-1); m++)
            {
                for (int i = 0; i < c; i++)
                {

                    for (int q = i + 1; q < c; q++)
                    {

                        if (sort[i].Name.Length > sort[q].Name.Length) { p = sort[q].Name.Length; }
                        else { p = sort[i].Name.Length; ; }
                        for (int j = 0; j < p; j++)
                        {


                            if (sort[i].Name[j] > sort[q].Name[j])
                            {
                                Person t = new Person(sort[i].Name, sort[i].Age);
                                sort[i].Name = sort[q].Name;
                                sort[i].Age = sort[q].Age;
                                sort[q].Name = t.Name;
                                sort[q].Age = t.Age;
                                if (j == 0) { i++; }
                            }

                            if (sort[i].Name[j] < sort[q].Name[j])
                            {
                                Person t = new Person(sort[q].Name, sort[q].Age);
                                sort[q].Name = sort[i].Name;
                                sort[q].Age = sort[i].Age;
                                sort[i].Name = t.Name;
                                sort[i].Age = t.Age;
                                if (j != 0) { i++; }
                            }



                        }

                    }
                }
            }
            
            
            for(int i=0;i<c;i++)
            {
                Console.WriteLine($"{sort[i].Name} {sort[i].Age}");
            }
        }
    }
}
