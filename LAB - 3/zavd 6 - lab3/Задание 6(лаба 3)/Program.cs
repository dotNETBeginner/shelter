using System;
using System.Collections;
using System.Collections.Generic;
namespace Задание_6_лаба_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of employees:");
            int n = Convert.ToInt32(Console.ReadLine());
            List<Employee> a = new List<Employee>();
            Console.WriteLine("Input employees: ");
            for (int i = 0; i < n; i++)
            {
                string s1 = Console.ReadLine();
                string[] s2 = s1.Split(" ");
                if (s2.Length == 6)
                {
                    Employee t = new Employee(s2[0], float.Parse(s2[1]), s2[2], s2[3], s2[4], Int32.Parse(s2[5]));
                    a.Add(t);
                }
                if (s2.Length == 5)
                {
                    if (s2[4][0] == '1' || s2[4][0] == '2' || s2[4][0] == '3' || s2[4][0] == '4' || s2[4][0] == '5' || s2[4][0] == '6' ||
                        s2[4][0] == '7' || s2[4][0] == '8' || s2[4][0] == '9' || s2[4][0] == '0')
                    {
                        Employee t = new Employee(s2[0], float.Parse(s2[1]), s2[2], s2[3], Int32.Parse(s2[4]));
                        a.Add(t);

                    }
                    else
                    {
                        Employee t = new Employee(s2[0], float.Parse(s2[1]), s2[2], s2[3], s2[4]);
                        a.Add(t);
                        
                    }
                }
                if (s2.Length == 4)
                {
                    Employee t = new Employee(s2[0], float.Parse(s2[1]), s2[2], s2[3]);
                    a.Add(t);
                }
            }           
            List<string> deps = new List<string>();

            for (int i = 0; i < n; i++)
            {
                bool exists = false;
                for (int j = 0; j < deps.Count; j++)
                    if (deps[j] == a[i].Department)
                        exists = true;
                if (!exists)
                    deps.Add(a[i].Department);
            }  

            float[] sal_dep = new float[deps.Count];
            int m = deps.Count;
            for (int i = 0; i < m; i++)
                sal_dep[i] = 0;

            for (int i = 0; i < m; i++)
            {
                int k = 0;
                for (int j = 0; j < n; j++)
                {
                    if (a[j].Department == deps[i])
                    {
                        k++;
                        sal_dep[i] += a[j].Salary;
                    }
                }
                sal_dep[i] /= k;
            }
            float sal_max = sal_dep[0];
            int best = 0;
            for (int i = 0; i < m; i++)
            {
                if (sal_dep[i] > sal_max)
                {
                    sal_max = sal_dep[i];
                    best = i;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    if (a[i].Salary > a[j].Salary)
                    {
                        Employee t = new Employee();
                        t = a[i];
                        a[i] = a[j];
                        a[j] = t;

                    }
            }      


            Console.WriteLine($"Highest average salary: {deps[best]}");
            for (int i = 0; i < n; i++)
            {
                if (a[i].Department == deps[best])
                {
                    a[i].Display();
                }
            }
        }
    }
}