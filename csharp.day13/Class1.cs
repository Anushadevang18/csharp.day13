using System;



namespace infinite.Csharp.Day13
{
    internal class Employee
    {
        double basicSalary;
        double bonus;
        int employeeId;

        public double BasicSalary { get; set; }
        public double Bonus { get; set; }
        public int EmployeeId { get; set; }

        public Employee()
        {
            basicSalary = 10000;
        }

        public virtual double CalculateSalary()
        {
            return basicSalary;
        }

        public class SystemsEngineer : Employee
        {
            public double SpecialistAllowance { get; set; }
            public string Specialization { get; set; }

            public SystemsEngineer(string specialization)
            {
                Specialization = specialization;
            }


            public double CalculateSalary(String spec)
            {
                // base.CalculateSalary();
                string[] s1 = new string[] { "c#", "java", "SQL" };

                foreach (string s in s1)
                {

                    if (spec.Equals(s))
                    {
                        SpecialistAllowance = 3000;
                    }
                    else
                        return 0.0;
                }

                double salary = BasicSalary + SpecialistAllowance;
                return salary;


            }

            class Manager : Employee
            {
                public double PhoneAllowance { get; set; }

                public Manager()
                {
                    PhoneAllowance = 4000;
                }

                public override double CalculateSalary()
                {
                    base.CalculateSalary();
                    return base.CalculateSalary();
                }

                class SeniorProjectManager : Employee
                {
                    public double CarAllowance { get; set; }
                    public SeniorProjectManager()
                    {
                        CarAllowance = 6000;
                    }
                    public override double CalculateSalary()
                    {
                        return base.CalculateSalary();
                    }

                }
                class Finance
                {
                    public double Bonus { get; set; }

                    public double GetCalculateSalary(Employee obj)
                    {
                        int op;
                        double totalSalary;

                        Console.WriteLine("Enter your object: ");
                        Console.WriteLine($"1:SystemsEngineer \n 2: Manager \n 3: SeniorProjectManager ");
                        op = int.Parse(Console.ReadLine());

                        SystemsEngineer se1 = new SystemsEngineer("java");
                        switch (op)
                        {

                            case 1:
                                Bonus = 5000;
                                double s = se1.CalculateSalary("java");

                                totalSalary = s + Bonus;
                                Console.WriteLine(totalSalary);
                                break;
                            case 2:
                                Bonus = 9000;
                                double s1 = obj.CalculateSalary();
                                totalSalary = s1 + Bonus;
                                Console.WriteLine(totalSalary);
                                break;
                            case 3:
                                Bonus = 15000;
                                double s3 = obj.CalculateSalary();
                                totalSalary = s3 + Bonus;
                                Console.WriteLine(totalSalary);
                                break;
                            default: return 0.0;


                        }
                        return totalSalary;


                    }


                    public static void Main56(string[] args)
                    {
                        Employee emp = new Employee();
                        emp.CalculateSalary();
                        Finance f1 = new Finance();
                        f1.GetCalculateSalary(emp);


                    }
                }
            }
        }
    }
}

