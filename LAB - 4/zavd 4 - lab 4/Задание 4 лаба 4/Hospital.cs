using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_4_лаба_4
{
    class Hospital
    {
        List<Department> someDepartments = new List<Department>();
        List<Doctor> someDoctors = new List<Doctor>();

        public Hospital()
        {
            Department t = new Department("Cardiology");
            someDepartments.Add(t);
            Department t1 = new Department("Oncology");
            someDepartments.Add(t1);
            Department t2 = new Department("Emergency");
            someDepartments.Add(t2);
        }

        public void Add(string nameOfDepartment, string doctorsName, string doctorsSurName, string patientName)
        {
            for (int i = 0; i < someDepartments.Count; i++)
            {
                if (nameOfDepartment == someDepartments[i].NameOfDepartment)
                {
                    someDepartments[i].addPatientInRoom(patientName);
                    Console.WriteLine("addPAtientInRoom is started");
                    if (someDoctors.Count == 0)
                    { Doctor t = new Doctor(doctorsName, doctorsSurName, patientName); someDoctors.Add(t); }
                    else
                    {
                        for (int j = 0; j < someDoctors.Count; j++)
                        {
                            if (doctorsName != someDoctors[j].Name && doctorsSurName != someDoctors[j].SurName)
                            { Doctor t = new Doctor(doctorsName, doctorsSurName, patientName); someDoctors.Add(t); break; }
                            else if (doctorsName == someDoctors[j].Name && doctorsSurName == someDoctors[j].SurName) { someDoctors[j].AddPatient(patientName); break; }
                        }
                        break;
                    }
                }
            }
        }

        public void DisplayPatients(string arg1, string arg2)
        {
            for (int i = 0; i < someDoctors.Count; i++)
            {
                if (arg1 == someDoctors[i].Name && arg2 == someDoctors[i].SurName)
                {
                    for (int j = 0; j < someDoctors[i].somePatients.Count; j++)
                    {
                        Console.WriteLine(someDoctors[i].somePatients[j].Name);
                    }
                }
            }

            for (int i = 0; i < someDepartments.Count; i++)
            {
                if (arg1 == someDepartments[i].NameOfDepartment)
                {
                    for (int j = 0; j < someDepartments[i].someRooms.Count; j++)
                    {
                        if (int.Parse(arg2)-1 == j)
                        {
                            for (int q = 0; q < someDepartments[i].someRooms[j].somePatients.Count; q++)
                            {
                                Console.WriteLine(someDepartments[i].someRooms[j].somePatients[q].Name);
                            }
                        }
                    }
                }
            }
        }

        public void DisplayPatients(string arg1)
        {
            for (int i = 0; i < someDepartments.Count; i++)
            {
                if (arg1 == someDepartments[i].NameOfDepartment)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        for (int q = 0; q < someDepartments[i].someRooms[j].somePatients.Count; q++)
                            Console.WriteLine(someDepartments[i].someRooms[j].somePatients[q].Name);
                    }
                }
            }
        }
}
    }
