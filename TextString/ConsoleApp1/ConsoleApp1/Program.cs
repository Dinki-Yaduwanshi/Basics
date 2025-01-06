using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int a = 5
             , b = 10;

             int lrem = b % a;
             Console.WriteLine("The first remainder :" + rem);
             b = 23;
             rem = b % a;

             Console.WriteLine("The second remainder :" + rem);
             Console.ReadLine();*/

            Console.WriteLine("Enter the first number :"); // first number
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number :");//second number
            int b = Convert.ToInt32(Console.ReadLine());

            int ans = a * b;
            Console.WriteLine("The number " + a + " times " + b + "is : ");
            int check = Convert.ToInt32(Console.ReadLine());

            if (ans == check)
            {
                Console.WriteLine("Your answer is correct");

            }
            else
            {
                Console.WriteLine("Your answer is incorrect");
            }

            Console.ReadLine();
        }
    }
}
