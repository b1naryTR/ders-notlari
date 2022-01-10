using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_ilk
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("1-10 arasındaki sayılar");
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n10-1 arasındaki sayılar");
            for (i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
