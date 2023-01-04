using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Homework_9
{
    internal class Department :IDepartment
    {
        public string Name;
        public int EmployeeLimit;
        public int SalaryLimit;
        private Employee[] _employees = {};
        public Employee[] Employees => _employees;

        Employee[] IDepartment.Employees { get ; }

        public Employee CreateEmployee(string fullname, int salary)
        {
            if (CheckEmployeeSalaryLimit(salary)&& CheckEmployeeLimit())
            {
               Employee employee = new Employee()
                {
                    FullName = fullname,
                    Salary = salary,
                    StartDate = DateTime.Now,
                };
                return employee;
            }
            else
                try
                {
                    throw new Exception("Maas limiti 250 den asagi ola bilmez");
                }
                catch (Exception)
                {

                    throw;
                }

        }
        public void AddEmployee(Employee employee)
        {
            if (CheckEmployeeLimit() && CheckSalaryLimit())
            {
                Array.Resize(ref _employees, _employees.Length + 1);
                _employees[_employees.Length - 1] = employee;
            }
            else
                try
                {
                    throw new Exception("Limit asdi");
                }
                catch (Exception)
                {
                }
        }

        public  bool CheckEmployeeLimit()
        {
            if (_employees.Length < EmployeeLimit)
            {
                return true;
            }
            else
                return false;
        }
        public bool CheckSalaryLimit()
        {
            int sum = 0;
            for (int i = 0; i < _employees.Length; i++)
            {
                _employees[i].Salary += sum;
            }
            if (sum <= SalaryLimit)
            {
                return true;
            }
            else
                return false;
        }
        public void MakeSalaryLimit(int limit)
        {
            SalaryLimit = limit;
        }

        public bool CheckEmployeeSalaryLimit(int salary)
        {
            if (salary >= 250)
            {
                return true;
            }
            else
                return false;
        }

        public void ChangeSalaryByNo(int no,int newSalary)
        {
            for(int i=0;i< _employees.Length;i++)
            {
                if (no == _employees[i].No)
                {
                    _employees[i].Salary = newSalary;
                }
            }
        }

        public void Search(string input)
        {
            for(int i=0;i<_employees.Length;i++)
            {
                if (_employees[i].FullName.ToString().Contains(input))
                {
                    Console.WriteLine(_employees[i].FullName);
                }
            }
        }

        public void FindAllEmployees()
        {
            for(int i=0;i< _employees.Length;i++)
            {
                Console.WriteLine(_employees[i].FullName);
            }
        }
        
        public  void FindEmployeeByNo(int no)
        {
            for(int i = 0; i < _employees.Length; i++)
            {
                if (_employees[i].No == no)
                {
                    Console.WriteLine(_employees[i].FullName);
                }
            }
        }

        public void MakeEmployeeLimit(int limit)
        {
            EmployeeLimit=limit;
        }

        public void RemoveEmployee(int no)
        {
            for(int i=0;i< _employees.Length;i++)
            {
                if (_employees[i].No == no)
                {
                    Array.Resize(ref _employees,_employees.Length+1);
                    _employees[_employees.Length - 1] = _employees[i];
                    Array.Resize(ref _employees, _employees.Length-2);
                }
            }
        }

        public void SortByDateTime()
        {
            for(int i=0;i< _employees.Length;i++)
            {
                Console.WriteLine(_employees[i].FullName +_employees[i].StartDate);
            }
        }
    }
}