using System;
using System.Collections;
using System.Collections.Generic;
namespace Задание_6_лаба_3
{
    class Employee
    {
        public string Name { get; set; }
        public float Salary { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public Employee() { }
        public Employee(string Name, float Salary, string Position, string Department)
        {
            this.Name = Name;
            this.Salary = Salary;
            this.Position = Position;
            this.Department = Department;
            this.Email = "n/a";
            this.Age = -1;
        }
        public Employee(string Name, float Salary, string Position, string Department, string Email)
        {
            this.Name = Name;
            this.Salary = Salary;
            this.Position = Position;
            this.Department = Department;
            this.Email = Email;
            this.Age = -1;
        }
        public Employee(string Name, float Salary, string Position, string Department, int Age)
        {
            this.Name = Name;
            this.Salary = Salary;
            this.Position = Position;
            this.Department = Department;
            this.Email = "n/a";
            this.Age = Age;
        }
        public Employee(string Name, float Salary, string Position, string Department, string Email, int Age)
        {
            this.Name = Name;
            this.Salary = Salary;
            this.Position = Position;
            this.Department = Department;
            this.Email = Email;
            this.Age = Age;
        }
        public void Display()
        {
            Console.WriteLine($"{Name} {Salary.ToString("0.00")} {Position} {Department} {Email} {Age}");//two decimal?
        }
    }