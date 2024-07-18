using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String a = "abc";
            char ch = 'a';
            //Console.WriteLine( );
            Console.Write( "Your name is : ");
            Console.WriteLine(a);


            string name = " g";
            //string can store up empty value but char cant

            char g = '\0'; // store escape 0 for blank
            Console.WriteLine(name);
            Console.Write(g);


            //  Converting String to Numbers
            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine( age);

            string textBigNumber = "900000";
            long l = Convert.ToInt64(textBigNumber); //for long is toInt64
            Console.WriteLine( l);


            string textNegative = "-56.8";
            double n= Convert.ToDouble(textNegative);
            Console.WriteLine(n);

            string textPrecision = "5.00009";
            float f = Convert.ToSingle(textPrecision);
            Console.WriteLine(f);

            string textMoney = "15.89";
            decimal d= Convert.ToDecimal(textMoney);
            Console.WriteLine(d);




            Console.ReadLine();
        }
    }
}
