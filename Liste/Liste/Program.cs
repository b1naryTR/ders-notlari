using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char[] isim = {'F','A','T','İ','H'};
            /*for(int i=0 ; i<=4 ; i++)
            {
                Console.WriteLine(isim[i]);
            }
            */
            int sayi = 1;
            foreach(char karakter in isim)
            {
                Console.WriteLine(sayi+".Karakter="+karakter);
                sayi++;
            }
            Console.ReadKey();



        }
    }
}
