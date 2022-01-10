using System;

namespace Örnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad;
            int yas;
            Console.Write("Adınızı Giriniz: ");
            ad = Console.ReadLine();
            Console.Write("Soyadınızı Giriniz: ");
            soyad = Console.ReadLine();
            Console.Write("Yaşınızı Giriniz: ");
            yas = Convert.ToInt16(Console.ReadLine());
            Console.Write("Hoşgeldiniz " + ad + " " + soyad + "\nYaşınız: " + yas);

            Console.ReadKey();
        }
    }
}
