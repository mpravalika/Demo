using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class loopex2
    {
        static void Main(string[] args)
        {
            int i, j;
            i = 0;
            while (i < 5)
            {
                j = 0;
                while (j < 5)
                {
                    Console.WriteLine(i +" "+ j);
                    j++;
                }

                i++;
            }
            Console.Read();
        }
    }
}
