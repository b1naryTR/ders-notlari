using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merhaba
{
    class Program
    {
        static void ad_soyad(string ad, string soyad)
        {
            Console.Write("Ad : " + ad);
            Console.Write("\nSoyad : " + soyad);
        }
        static void Main(string[] args)
        {
            Console.Write("Adınızı Girin: ");
            string ad = Console.ReadLine();
            Console.Write("Soyadınızı Girin: ");
            string soyad = Console.ReadLine();
            ad_soyad(ad, soyad);

            Console.ReadKey();
        }
    }
}
