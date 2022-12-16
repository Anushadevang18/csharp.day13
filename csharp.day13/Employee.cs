using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.day13
{
    class Employee
    {
        double basicSalary, bonus;
        int employeeId;

        public double BasicSalary { get; set; }
        public double Bonus { get; set; }
        public int EmployeeId { get; set; }

        public Employee()
        {
            BasicSalary = 10000;
        }
        public virtual double CalculateSalary()
        {
            return BasicSalary;
        }


        public class SystemsEngineer : Employee
        {
            public double SpecialistAllowance { get; set; }
            public string Specialization { get; set; }
            public SystemsEngineer(string specialization)
            {
                Specialization = specialization;
            }
            public double CalculateSalary()
            {
                if (Specialization == "c#" || Specialization == "java" || Specialization == "sql")
                {
                    SpecialistAllowance = 3000;

                }
                else
                {
                    SpecialistAllowance = 0.0f;
                }
                double Salary = BasicSalary + SpecialistAllowance;
                return Salary;
            }

            public class Manager : Employee
            {
                public double PhoneAllowance { get; set; }

                public Manager()
                {
                    PhoneAllowance = 4000;
                }

                public double CalculateSalary()
                {
                    double Salary = BasicSalary + PhoneAllowance;
                    return Salary;

                }
                public class SeniorProjectManager : Employee
                {
                    public double CarAllowance { get; set; }
                    public SeniorProjectManager()
                    {
                        CarAllowance = 6000;
                    }
                    public double CalculateSalary()
                    {
                        double Salary = BasicSalary + CarAllowance;
                        return Salary;
                    }
                    class Finance
                    {
                        public double Bonus { get; set; }
                        public double GetCalculateSalary(Employee obj)
                        {
                            int option;
                            double totalSalary;
                            Console.WriteLine("Enter your object: ");
                            Console.WriteLine($"1:SystemsEngineer \n 2: Manager \n 3: SeniorProjectManager ");
                            option = int.Parse(Console.ReadLine());
                            switch (option)
                            {
                                case 1:
                                    Bonus = 5000;
                                    double BasicSalary = obj.CalculateSalary();
                                    totalSalary = BasicSalary+ Bonus;
                                    Console.WriteLine(totalSalary);
                                    break;
                                case 2:
                                    Bonus = 9000;
                                    double BasicSalary1 = obj.CalculateSalary();
                                    totalSalary = BasicSalary1+ Bonus;
                                    Console.WriteLine(totalSalary);
                                    break;
                                case 3:
                                    Bonus = 15000;
                                    double BasicSalary2 = obj.CalculateSalary();
                                    totalSalary = BasicSalary2 + Bonus;
                                    Console.WriteLine(totalSalary);
                                    break;
                                default: return 0.0;

                            }
                            return totalSalary;
                        }
                        public static void Main(string[] args)
                        {
                            Employee emp = new Employee();
                            emp.CalculateSalary();
                            Finance f1 = new Finance();
                            f1.GetCalculateSalary(emp);
                            SystemsEngineer s = new SystemsEngineer("java");
                            s.CalculateSalary();
                        }
                    }
                }
            }
        }
    }
}




    