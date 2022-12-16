using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.day13
{
    class Patient

    {
        public int Age { get; set; }
        public double ConsultationFee { get; set; }
        public Char Gender { get; set; }
        public string Illness { get; set; }
        public string Name { get; set; }

        public double CalculateConsultationFee()
        {
            if (Age > 0 && Age <= 18)
            {
                ConsultationFee = Age * 10;
            }
            else
            {
                ConsultationFee = Age * 15;

            }
            return ConsultationFee;

        }
        public Patient()
        {

        }
        public Patient(string name, int age, char gender, string illness)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Illness = illness;
        }
        public class InPatient : Patient
        {
            public int days
            {
                get { return days; }
                set
                {
                    if (value > 0)
                    {
                        days = value;
                    }
                    else
                    {
                        days = 1;
                    }
                }
            }

            public int Days { get; set; }
            public double ExtraService { get; set; }
            public double PerDayService { get; set; }
            public InPatient()
            {
                PerDayService = 155.50;
                ExtraService = 100;

            }
            public InPatient(string name, int age, char gender, string illness, int days)
            {
                Name = name;
                Age = age;
                Gender = gender;
                Illness = illness;
                Days = days;
            }
            public double RoomCharge()
            {
                double ServiceCharge = 0;
                if (days <= 7)
                {
                    ServiceCharge = days * 155.50;
                }
                if (days > 7)
                {
                    ServiceCharge = ((days * 155.50) + (days * 100));

                }
                return ServiceCharge;


            }
            public new double CalculateConsultationFee()
            {
                double CalculateConsultationFee = base.CalculateConsultationFee() + 100;
                return CalculateConsultationFee;
            }

        }

        public class OutPatient : Patient
        {
            public OutPatient()
            {

            }


            public OutPatient(string name, int age, char gender, string illness)
            {
                Name = name;
                Age = age;
                Gender = gender;
                Illness = illness;

            }
            public new double CalculateConsultationFee()
            {

                if (Illness == "cough " || Illness == "fever")
                {
                    double CalculateConsultationFee = base.ConsultationFee - 10;
                    return CalculateConsultationFee;
                }
                else
                {
                    double CalculateConsultationFee = base.ConsultationFee + 10;
                    return CalculateConsultationFee;
                }
                return ConsultationFee;
            }
            public class Bill
            {
                public Bill()
                {

                }
                public double GenerateBill(Patient obj)
                {
                    InPatient obj1 = new InPatient();
                    OutPatient obj2 = new OutPatient();
                    double billAmount = 0.0;
                    if (obj1 == obj)
                    {
                        return obj.CalculateConsultationFee();
                    }
                    else if (obj2 == obj)
                    {
                        return obj.CalculateConsultationFee();
                    }
                    else
                    {//using System;



                        //namespace infinite.Csharp.Day13
                        //{
                        //    internal class Employee
                        //    {
                        //        double basicSalary;
                        //        double bonus;
                        //        int employeeId;

                        //        public double BasicSalary { get; set; }
                        //        public double Bonus { get; set; }
                        //        public int EmployeeId { get; set; }

                        //        public Employee()
                        //        {
                        //            basicSalary = 10000;
                        //        }

                        //        public virtual double CalculateSalary()
                        //        {
                        //            return basicSalary;
                        //        }

                        //        public class SystemsEngineer : Employee
                        //        {
                        //            public double SpecialistAllowance { get; set; }
                        //            public string Specialization { get; set; }

                        //            public SystemsEngineer(string specialization)
                        //            {
                        //                Specialization = specialization;
                        //            }


                        //            public double CalculateSalary(String spec)
                        //            {
                        //                // base.CalculateSalary();
                        //                string[] s1 = new string[] { "c#", "java", "SQL" };

                        //                foreach (string s in s1)
                        //                {

                        //                    if (spec.Equals(s))
                        //                    {
                        //                        SpecialistAllowance = 3000;
                        //                    }
                        //                    else
                        //                        return 0.0;
                        //                }

                        //                double salary = BasicSalary + SpecialistAllowance;
                        //                return salary;


                        //            }

                        //            class Manager : Employee
                        //            {
                        //                public double PhoneAllowance { get; set; }

                        //                public Manager()
                        //                {
                        //                    PhoneAllowance = 4000;
                        //                }

                        //                public override double CalculateSalary()
                        //                {
                        //                    base.CalculateSalary();
                        //                    return base.CalculateSalary();
                        //                }

                        //                class SeniorProjectManager : Employee
                        //                {
                        //                    public double CarAllowance { get; set; }
                        //                    public SeniorProjectManager()
                        //                    {
                        //                        CarAllowance = 6000;
                        //                    }
                        //                    public override double CalculateSalary()
                        //                    {
                        //                        return base.CalculateSalary();
                        //                    }

                        //                }
                        //                class Finance
                        //                {
                        //                    public double Bonus { get; set; }

                        //                    public double GetCalculateSalary(Employee obj)
                        //                    {
                        //                        int op;
                        //                        double totalSalary;

                        //                        Console.WriteLine("Enter your object: ");
                        //                        Console.WriteLine($"1:SystemsEngineer \n 2: Manager \n 3: SeniorProjectManager ");
                        //                        op = int.Parse(Console.ReadLine());

                        //                        SystemsEngineer se1 = new SystemsEngineer("java");
                        //                        switch (op)
                        //                        {

                        //                            case 1:
                        //                                Bonus = 5000;
                        //                                double s = se1.CalculateSalary("java");

                        //                                totalSalary = s + Bonus;
                        //                                Console.WriteLine(totalSalary);
                        //                                break;
                        //                            case 2:
                        //                                Bonus = 9000;
                        //                                double s1 = obj.CalculateSalary();
                        //                                totalSalary = s1 + Bonus;
                        //                                Console.WriteLine(totalSalary);
                        //                                break;
                        //                            case 3:
                        //                                Bonus = 15000;
                        //                                double s3 = obj.CalculateSalary();
                        //                                totalSalary = s3 + Bonus;
                        //                                Console.WriteLine(totalSalary);
                        //                                break;
                        //                            default: return 0.0;


                        //                        }
                        //                        return totalSalary;


                        //                    }


                        //                    public static void Main56(string[] args)
                        //                    {
                        //                        Employee emp = new Employee();
                        //                        emp.CalculateSalary();
                        //                        Finance f1 = new Finance();
                        //                        f1.GetCalculateSalary(emp);


                        //                    }
                        //                }
                        //            }
                        //        }
                        //    }
                        //}

                        return billAmount;
                    }
                }
            }
            public static void Main123(string[] args)
            {
                Patient p = new Patient();
                p.CalculateConsultationFee();
                Bill b = new Bill();
                Console.WriteLine(b.GenerateBill(p));
                InPatient p1 = new InPatient();
                p1.CalculateConsultationFee();
                OutPatient p2 = new OutPatient();
                p2.CalculateConsultationFee();
                Console.WriteLine("enter name :");
                string name = Console.ReadLine();
                Console.WriteLine("enter age :");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("enter Gender :");
                char gender = char.Parse(Console.ReadLine());
                Console.WriteLine("enter Illness :");
                string illness = Console.ReadLine();
                Console.WriteLine("enter the days :");
                int days = int.Parse(Console.ReadLine();
            }



        }
    }
}
















