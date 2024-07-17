using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int age = 23;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);

            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            long bigNumber = 900000L;

            double d = 3.14;
            Console.WriteLine(d);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);


            float f = 4.00001F;
            Console.WriteLine(f);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            decimal money = 4.8M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);


            Console.WriteLine(bigNumber);
            Console.ReadLine();
        }
    }
}

