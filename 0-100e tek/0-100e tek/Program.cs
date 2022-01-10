using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_100e_tek
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int sayac = 1;
            for (int i = 1; i < 100; i+=2)
            {
                Console.WriteLine(sayac +"-> " + i);
                sayac++;

            }
            Console.ReadKey();
        }
    }
}
