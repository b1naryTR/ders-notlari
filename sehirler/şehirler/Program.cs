using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace şehirler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar;
            sayilar = new int[21];
            int indis = 0;
            for (int i = 0; i <=100;i++)
            {
               
                if (i % 5 == 0)
                {
                    sayilar[indis] = i;
                    indis++;

                }



            }
            foreach (int k in sayilar)
                Console.WriteLine(k);
            Console.ReadKey();
            
        }
    }
}
