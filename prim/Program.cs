using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim
{
    class Program
    {
        static void Main(string[] args)
        {
            int prim, parca, maas, topmaas;
            Console.Write("Maaşınızı giriniz: ");
            maas = Convert.ToInt16(Console.ReadLine());
            Console.Write("Ürettiğiniz ürün miktarını giriniz: ");
            parca = Convert.ToInt16(Console.ReadLine());
            if (parca >= 1 && parca < 11)
            {
                topmaas = (parca * 5) + maas;
                prim = (parca * 5);
                Console.Write("Normal Maaş= " + maas + "\nPrim: " + prim + "\nToplam maaşınız: " + topmaas);
            }
            else if (parca >= 11 && parca < 26)
            {
                topmaas = (parca * 11) + maas;
                prim = (parca * 11);
                Console.Write("Normal Maaş= " + maas + "\nPrim: " + prim + "\nToplam maaşınız: " + topmaas);
            }
            else if (parca >= 26 && parca < 41)
            {
                topmaas = (parca * 17) + maas;
                prim = (parca * 17);
                Console.Write("Normal Maaş= " + maas + "\nPrim: " + prim + "\nToplam maaşınız: " + topmaas);
            }
            else if (parca >= 41)
            {
                topmaas = (parca * 30) + maas;
                prim = (parca * 30);
                Console.Write("Normal Maaş= " + maas + "\nPrim: " + prim + "\nToplam maaşınız: " + topmaas);
            }
            else
            {
                prim = 0;
                Console.Write("Normal Maaş= " + maas + "\nPrim: " + prim + "\nToplam maaşınız: " + maas);
            }
            Console.ReadKey();
        }
    }
}
