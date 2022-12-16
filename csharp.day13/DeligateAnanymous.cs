using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.day13
{
    class DeligateEx
    {
        public float CalculateTotalMarks(float a1, float a2, float a3)
        {
            return a1 + a2 + a3;
        }

        public string WelcomeMessage(int id, string name)
        {
            return $"hi { name},  your employee id is  { id}";


        }
        public static void Main8(string[] args)
        {
            DeligateEx del = new DeligateEx();
            Func<float, float, float, float> totalmarks = del.CalculateTotalMarks;
            var result = totalmarks(80, 30, 70);
            Console.WriteLine(result);

            //welcome msg method
            Func<int, string, string> f = del.WelcomeMessage;
            var res = f(345, "anu");
            Console.WriteLine(res);

        }
    }

}