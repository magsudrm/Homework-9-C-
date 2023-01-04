using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_9
{
    internal class Employee
    {
        private static int _noCount;
        private int _no;
        private string _fullName;
        private int _salary;
        public DateTime StartDate;

        public int No => _no;

        
        public Employee()
        {
            _noCount++;
            _no = _noCount;
        }
        public string FullName
        {
            get => _fullName;
            set
            {
                if(IsFullNameTrue(value))
                    _fullName = value;
            }
        }

        public int Salary
        {
            get => _salary;
            set
            {
                _salary = value;
            }
        }

        static bool IsFullNameTrue(string fullname)
        {

            bool FullName = true;
            bool IsDigit = false;
            bool TwoWord = false;
            bool IsUpper = false;
            bool IsLower = false;
            if (char.IsUpper(fullname[0]) && char.IsUpper(fullname[fullname.IndexOf(' ') + 1]))
            {
                IsUpper = true;
            }
            if (fullname.Contains(' '))
            {
                TwoWord = true;
            }
            for (int i = 1; i < fullname.IndexOf(' '); i++)
            {
                if (char.IsDigit(fullname[i]))
                {
                    IsDigit = true;
                }
                if (char.IsLower(fullname[i]))
                {
                    IsLower = true;
                }
                else
                {
                    IsLower = false;
                    break;
                }
            }
            for (int i = fullname.IndexOf(' ') + 2; i < fullname.Length; i++)
            {
                if (char.IsDigit(fullname[i]))
                {
                    IsDigit = true;
                }
                if (IsLower == false)
                {
                    break;
                }
                if (char.IsLower(fullname[i]))
                {
                    IsLower = true;
                }
                else
                {
                    IsLower = false;
                    break;
                }
            }
            if (IsDigit == false && IsUpper == true && TwoWord == true && IsLower == true)
            {
                return FullName;
            }
            else return FullName = false;
        }

    }
}
