using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.day13
{
    public delegate int CalculateDelegate(int x, int y);
    class MulticastDelegate

    {
        public static int Add(int a, int b)
        {
            Console.WriteLine(a + b);
            return a + b;
        }
        public static int multi(int v, int d)
        {

            Console.WriteLine(v * d);
            return v * d;
        }
        public static void Main23(string[] args)
        {
            //CalculateDelegate del = new CalculateDelegate(Delegate.Add);
            ////CalculateDelegate d1 = new CalculateDelegate(new Delegate().multi);
            //int res = del(20, 40);
            //Console.WriteLine(res);
            // MulticastDelegate d1 = new MulticastDelegate();

            // multicast delegate
            CalculateDelegate del = MulticastDelegate.Add;
            del += MulticastDelegate.multi;
            var res = del(12, 3);
            Console.WriteLine(res);

        }
    }
}

