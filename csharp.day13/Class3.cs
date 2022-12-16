using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insinite.csharp.day15
{
    public delegate int Arthmetic(int number1, int number2);
    internal class ArthmeticOperators
    {
        public static int Add(int number1, int number2)
        {
            int res = number1 + number2;
            Console.WriteLine($"Add is :{res}");
            return res;
        }
        public static int Subtract(int number1, int number2)
        {
            int res = number1 - number2;
            Console.WriteLine($"subtraction is : {res}");
            return res;
        }
        public static int Multiply(int number1, int number2)
        {
            int res = number1 * number2;
            Console.WriteLine($"Multiplication is : {res}");
            return res;
        }
        public static int Divide(int number1, int number2)
        {
            int res = number1 / number2;
            Console.WriteLine($"Division is : {res}");

            return res;
        }
        public static int Max(int number1, int number2)
        {

            int Max = number1 > number2 ? number1 : number2;
            Console.WriteLine($"Maximum number is : {Max}");
            return Max;
        }

        public static void Main(string[] args)
        {
            {

                Console.WriteLine("enter Number 1 :");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("enter Number 2 :");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("enter the choice ( +, -, *, / , max): ");
                var ch = Console.ReadLine();

                switch(ch)
                {
                    case "+":
                        Arthmetic Add = new Arthmetic(ArthmeticOperators.Add); // refering static 
                        Add(num1, num2);
                        break;
                    case "-":
                        Arthmetic Subtract = new Arthmetic(ArthmeticOperators.Subtract);
                        Subtract(num1, num2);
                        break;

                    case "*":
                        Arthmetic Multiply = new Arthmetic(ArthmeticOperators.Multiply);
                        Multiply(num1, num2);
                        break;

                    case "/":
                        Arthmetic Divide = new Arthmetic(ArthmeticOperators.Divide);
                        Divide(num1, num2);
                        break;

                    case "max":
                        Arthmetic Max = new Arthmetic(ArthmeticOperators.Max);
                        Max(num1, num2);
                        break;

                    default:
                        Console.WriteLine("invalid input");
                        break;
                }
            }
        }
    }
}



