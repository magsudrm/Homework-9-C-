using System;
using System.Security.Cryptography.X509Certificates;

namespace Homework_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department programming = new Department();

            string opt;
            do
            {
                Console.WriteLine("1. Salary limit elave et");
                Console.WriteLine("2. Employee limit elave et");
                Console.WriteLine("3. Employee elave et");
                Console.WriteLine("4. Isciler uzerinde axtaris et");
                Console.WriteLine("5. Butun iscilere bax");
                Console.WriteLine("6. Tarixe gore iscilere bax");
                Console.WriteLine("7. No ye gore isciye bax");
                Console.WriteLine("8. No ye gore iscini sil");
                Console.WriteLine("9. Employee maasini deyisdir");
                Console.WriteLine("0. Prosesi bitir");
                opt = Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        Console.WriteLine("Salary limiti elave et");
                        int limit = GetConvert();
                        programming.MakeSalaryLimit(limit);
                        break;
                    case "2":
                        Console.WriteLine("Employee Limit elave et");
                        int limit2 = GetConvert();
                        programming.MakeEmployeeLimit(limit2);
                        break;
                    case "3":
                        Console.WriteLine("Adinzi Daxil Edin");
                        string fullname = Console.ReadLine();
                        Console.WriteLine("Maasi daxil edin");
                        int salary = GetConvert();
                        programming.AddEmployee(programming.CreateEmployee(fullname, salary));
                        break;
                    case "4":
                        Console.WriteLine("Axtaris deyerini daxil edin");
                        string search = Console.ReadLine();
                        programming.Search(search);
                        break;
                    case "5":
                        programming.FindAllEmployees();
                        break;
                    case "6":
                        programming.SortByDateTime();
                        break;
                    case "7":
                        Console.WriteLine("Iscinin No daxil edin");
                        int no2 = GetConvert();
                        programming.FindEmployeeByNo(no2);
                        break;
                    case "8":
                        Console.WriteLine("Silmek istediyiniz iscinin No daxil edin");
                        int no3 = GetConvert();
                        programming.RemoveEmployee(no3);
                        break;
                    case "9":
                        Console.WriteLine("Iscinin No daxil edin");
                        int no = GetConvert();
                        Console.WriteLine("Iscinin yeni maasini daxil edin");
                        int newSalary = GetConvert();
                        programming.ChangeSalaryByNo(no, newSalary);
                        break;
                    case "0":
                        Console.WriteLine("Proses bitdi");
                        return;
                    default:
                        break;
                }

            } while (true);
        }

        static int GetConvert()
        {
            int input = 0;
            string inputStr = Console.ReadLine();
            try
            {
                 input = Convert.ToInt32(inputStr);
            }
            catch (Exception e)
            {

                Console.WriteLine("Xeta bas verdi: "+e.Message);
            }
            return input;
        }
    }
}
