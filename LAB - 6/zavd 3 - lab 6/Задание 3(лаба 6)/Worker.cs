using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_3_лаба_6_
{
    class Worker : Human
    {
        private float weekSalary;
        private int workHoursPerDay;

        public float WeekSalary
        {
            get { return weekSalary; }
            set
            {
                if(value <= 10 )
                { throw new ArgumentException("Expected value mismatch! Argument: weekSalary"); }
                else { weekSalary = value; }
            }
        }

        public int WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set
            {
                if (value < 1 || value > 12)
                { throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay"); }
                else { workHoursPerDay = value; }
            }
        }

        public float SalaryPerHour { get; set; }

        public Worker(string firstName, string lastName, float weekSalary, int workHoursPerDay)
            :base(firstName,lastName)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
            SalaryPerHour = (WeekSalary / 5) / WorkHoursPerDay;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Week Salary: {WeekSalary.ToString("0.00")}\n\nHours per day: {WorkHoursPerDay.ToString("0.00")}\n\nSalary per hour: {SalaryPerHour.ToString("0.00")}");
        }
    }
}
