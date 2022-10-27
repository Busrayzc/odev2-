using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt16(Console.ReadLine());
            int y = Convert.ToInt16(Console.ReadLine());
            if (x > y)
            {
                if (x % y == 0)
                {
                    Console.WriteLine(x + " ve " + y + " " + "birbirine tam bölünür");
                }
                else
                {
                    Console.WriteLine(x + " ve " + y + " " + "birbirine tam bölünmez");
                }

            }

            Console.ReadKey();





        }
    }
}
