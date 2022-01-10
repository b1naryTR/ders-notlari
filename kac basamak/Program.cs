using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kac_basamak
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
        baslangic:
            Console.Clear();
            Console.Write("Kaç basamaklı olduğunu merak ettiğiniz 0'dan 10000'e kadar olan bir sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bir sayi giriniz: ");
            if (sayi >= 0 && sayi<10)
            {
                Console.WriteLine("Girdiginiz sayı 1 basamaklıdır.");
            }
            else if (sayi >= 10 && sayi < 100)
            {
                Console.WriteLine("Girdiginiz sayı 2 basamaklıdır.");
            }
            if (sayi >= 100 && sayi < 1000)
            {
                Console.WriteLine("Girdiginiz sayı 3 basamaklıdır.");
            }
            if (sayi >= 1000 && sayi < 10000)
            {
                Console.WriteLine("Girdiginiz sayı 4 basamaklıdır.");
            }
            else
            {
                Console.Write("Geçerli bir sayı giriniz.");
            }
            Console.Write("Tekrar Denemek İster misiniz? (E/e)");
            char kont = Convert.ToChar(Console.ReadLine());
            if (kont == 'E' || kont == 'e')
            {
                goto baslangic;
            }


            Console.ReadLine();

        }
    }
}
