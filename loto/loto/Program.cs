using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int [6];
            Random rnd = new Random();
            int i = 0;
            while(i<=5)
            {
                
                int rastgele = rnd.Next(1, 49);
                int aranacak = rastgele;
                int sonuc = Array.IndexOf(sayilar, aranacak);
                if (sonuc == -1)
                {
                    sayilar[i] = rastgele;
                    i++;
                }
            }
            Array.Sort(sayilar);
            foreach(int j in sayilar)
            {
                Console.WriteLine(j);
            }
            Console.ReadKey();
        }
    }
}
