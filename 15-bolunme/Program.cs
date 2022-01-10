using System;

namespace _3_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, kalan;
            Console.Write("Bir sayı Giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            kalan = sayi % 15;
            if (sayi % 15 == 0)
            {
                Console.Write("Girdiğiniz Sayı 15'e Tam Bölünür");
            }
            else
            {
                Console.Write("Girdiğiniz Sayı 15'e Tam Bölünmez");
                if (kalan < 8)
                {
                    Console.Write("\nSayının 15'e tam bölünebilmesi için sayıdan " + kalan + " çıkarın");
                }
                else
                {
                    Console.Write("\nSayının 15'e tam bölünebilmesi için sayıya " + (15 - kalan) + " ekleyin");
                }

            }
            Console.ReadKey();
        }
    }
}
