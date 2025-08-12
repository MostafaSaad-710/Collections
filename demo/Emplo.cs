using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class EmployeeCompareName : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee X = (Employee) x;
            Employee Y = (Employee)y;
            return X.Name.CompareTo(Y.Name);
        }
    }

    internal class Employee : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public int CompareTo(object? obj)
        {
            Employee e = (Employee) obj;
            return this.Age.CompareTo(e.Age);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}, Age: {Age}";
        }
    }

}
