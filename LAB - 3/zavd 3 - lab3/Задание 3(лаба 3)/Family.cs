using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_3_лаба_3_
{
    class Family
    {
        Person[] member;
        
        public Family() { }

        public Family(int size)
        {
            member = new Person[size];
        }

         public void addMember(int i ,string[] names, int[] ages)
        {
            member[i] = new Person(ages[i],names[i]);
        }
        public void printInfo()
        {
            for(int i=0;i<member.Length;i++)
            {
                Console.WriteLine($"{member[i].Name}  {member[i].Age}");
            }
        }
         public Person getOldestMember(int n)
        {
            
            int oldest=member[0].Age,k=0;
            for (int i = 0; i < n; i++)
            {
                if (member[i].Age > oldest) { oldest = member[i].Age; k = i; }
            }
            Console.WriteLine($"Самый страшый(ая) в семье - {member[k].Name}, ему(й) {member[k].Age} лет");
                return member[k];
            
        }
        
    }
}
