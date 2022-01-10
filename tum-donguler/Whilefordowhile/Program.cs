using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whilefordowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("FOR DÖNGÜSÜ");
            for(i=10;i<=5;i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("FOR DÖNGÜSÜ");
            int a = 10;
            while(a<=5)
            {
                Console.WriteLine(i);
                a++;

            }
            Console.WriteLine("DO-WHİLE DÖNGÜSÜ");
            int b = 10;
            do
            {
                Console.WriteLine(b);
                b++;
            } while (b <= 5);

            Console.ReadKey();




        }
    }
}
