using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_0_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int tekToplam = 0, ciftToplam = 0, sayi;
            Console.Write("Sayı Giriniz.");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " -> Çift");
                    ciftToplam = ciftToplam + i;
                }
                else
                {
                    Console.WriteLine(i + " -> Tek");
                    tekToplam = tekToplam + i;
                }
            }
            Console.WriteLine("0-"+sayi+" arası Tek Sayıların Toplamı : " + tekToplam);
            Console.WriteLine("0-"+ sayi + " arası Çift Sayıların Toplamı : " + ciftToplam);
            Console.ReadKey();
        }
    }
}
