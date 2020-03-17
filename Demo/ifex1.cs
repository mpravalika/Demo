using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class ifex1
    {
        static void Main(string[] args)
        {
            int i = 70;
            if (i > 70)
            {
                Console.WriteLine("excellent");
            }
            else if (i > 60)
            {
                Console.WriteLine("good");
            }
            else if (i > 50)
            {
                Console.WriteLine("improve");
            }
            else
            {
                Console.WriteLine("fail");
            }
            Console.Read();
        }
    }
}
