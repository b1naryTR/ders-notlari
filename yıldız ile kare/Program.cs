using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yıldız_ile_kare
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (i == 1 || i == 5 )
                        Console.Write("*");
                    else
                        if (j == 1 || j == 10)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
