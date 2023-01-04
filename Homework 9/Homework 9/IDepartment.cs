using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_9
{
    internal interface IDepartment
    {
        void RemoveEmployee( int no);
        Employee[] Employees { get; }
        void AddEmployee(Employee employee);
        void Search(string input);
    }
}
