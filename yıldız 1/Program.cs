using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yıldız_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)  
            {
                for (int j = 0; j < i; j++) 
                {
                    Console.Write("*"); 
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
