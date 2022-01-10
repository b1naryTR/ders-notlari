using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR_İ_VE_J
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.WriteLine("i= " + i + " j= " + j);
                }
                Console.WriteLine("---------------");
            }
            Console.ReadKey();
        }
    }
}
