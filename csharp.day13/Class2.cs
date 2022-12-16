using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinte.CSharp.Day15
{
    public delegate int ArithmrticOps(int number1, int number2);
    class ArithmeticOperations
    {
        public int AddNumbers(int x, int y)
        {
            Console.WriteLine("Addition is: " + (x + y));
            return (x + y);
        }

        public int MultiplyNumbers(int x, int y)
        {
            Console.WriteLine("Multiplication is: " + (x * y));
            return (x * y);
        }

        public int DivideNumbers(int x, int y)
        {
            Console.WriteLine("Division is: " + (x / y));
            return x / y;
        }

        public int SubtractNumbers(int x, int y)
        {
            Console.WriteLine("Subtraction is: " + (x - y));
            return x - y;
        }

        public int FindMaxNUmber(int x, int y)
        {
            if (x > y)
            {
                Console.WriteLine("Max NUmber is: " + x);
                return x;
            }
            Console.WriteLine("Max Number is: " + y);
            return y;
        }


        static void Main234(string[] args)
        {
            ArithmeticOperations calc = new ArithmeticOperations();


            Console.WriteLine("Enter Number 1: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number 2: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Operation ( + , * , / , - , Max)");
            var op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    ArithmrticOps Add = new ArithmrticOps(calc.AddNumbers);
                    Add(x, y);
                    break;
                case "*":
                    ArithmrticOps Mul = new ArithmrticOps(calc.MultiplyNumbers);
                    Mul(x, y);
                    break;
                case "/":
                    ArithmrticOps Div = new ArithmrticOps(calc.DivideNumbers);
                    Div(x, y);
                    break;
                case "-":
                    ArithmrticOps Sub = new ArithmrticOps(calc.SubtractNumbers);
                    Sub(x, y);
                    break;
                case "Max":
                    ArithmrticOps Max = new ArithmrticOps(calc.FindMaxNUmber);
                    Max(x, y);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;

            }
        }
    }
}
