using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infinite.day12
{
    public delegate int CalculateDelegate(int x, int y);

    internal class Delegate
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public int multi(int v, int d)
        {
            return v * d;
        }

        public static void Main2(string[] args)
        {
            CalculateDelegate del = new CalculateDelegate(Delegate.Add);
            CalculateDelegate d1 = new CalculateDelegate(new Delegate().multi);
            int res = del(20, 40);
            int res1 = d1(20, 30);
            Console.WriteLine(res);
            Console.WriteLine(res1);



        }
    }
}