




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int sayi1, sayi2;
            int toplama, cikarma, carpma, bolme, mod;
            Console.Write("1. Sayıyı Giriniz: ");
            sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz: ");
            sayi2 = Convert.ToInt16(Console.ReadLine());
            toplama = sayi1 + sayi2;
            cikarma = sayi1 - sayi2;
            carpma = sayi1 * sayi2;
            bolme = sayi1 / sayi2;
            mod = sayi1 % sayi2;
            Console.WriteLine("Toplama İşleminin Sonucu: " + toplama);
            Console.WriteLine("Çıkarma İşleminin Sonucu: " + cikarma);
            Console.WriteLine("Çarpma İşleminin Sonucu: " + carpma);
            Console.WriteLine("Bölme İşleminin Sonucu: " + bolme);
            Console.WriteLine("Mod Alma İşleminin Sonucu: " + mod);

            Console.ReadKey();
            */
            double sayi1, sayi2;
            double toplama, cikarma, carpma, mod;
            double bolme;
            Console.Write("1. Sayıyı Giriniz: ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz: ");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            toplama = sayi1 + sayi2;
            cikarma = sayi1 - sayi2;
            carpma = sayi1 * sayi2;
            bolme = sayi1 / sayi2;
            mod = sayi1 % sayi2;
            Console.WriteLine("Toplama İşleminin Sonucu: " + toplama);
            Console.WriteLine("Çıkarma İşleminin Sonucu: " + cikarma);
            Console.WriteLine("Çarpma İşleminin Sonucu: " + carpma);
            Console.WriteLine("Bölme İşleminin Sonucu: " + bolme);
            Console.WriteLine("Mod Alma İşleminin Sonucu: " + mod);

            Console.ReadKey();


        }
    }
}
