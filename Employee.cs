using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4___Collection_generics
{
    internal class Employee
    {
        public int ID { get; private set; }
        static int _ID = 100;  
        public string Name { get; private set; }
        public string Gender { get; private set; }
        public double Salary { get; private set; }
        public Employee( string name, string gender, double salary)
        {
            _ID++;
            ID = _ID;
            Name = name;
            Gender = gender;
            Salary = salary;

        }
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Gender: {Gender}, Salary: {Salary}");
        }
    }
    

}
