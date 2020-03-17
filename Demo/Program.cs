using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            double i, j;
            //accept thedata in console application
            //implicit conversionor boxing
            i = int.Parse(Console.ReadLine());

            int k, l;
            k = (int)double.Parse(Console.ReadLine());
            //explicit conversion or unboxing
            long m, n;
            m = (long)double.Parse(Console.ReadLine());
            l = (int)long.Parse(Console.ReadLine());
            Console.WriteLine(i);
            Console.WriteLine(k);
            Console.WriteLine(m);
            Console.WriteLine(l);
            Console.Read();


        }

    }
}
