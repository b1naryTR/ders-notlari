using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            int mod;
            Console.Write("1. Sayıyı Giriniz: ");
            sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz: ");
            sayi2 = Convert.ToInt16(Console.ReadLine());
            mod = sayi1 % sayi2;
            Console.WriteLine("Mod Alma İşleminin Sonucu: " + mod);

            Console.ReadKey();

        }
    }
}
