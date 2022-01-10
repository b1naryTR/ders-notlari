using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ödevdinamik2
{
    class Program
    {
        static void Main(string[] args)
        {
            int adet;
            Console.Write("Kaç adet sayı girmek istiyorsunuz: ");
            adet = Convert.ToInt32(Console.ReadLine());
            ArrayList sayilar = new ArrayList();
            for (int i = 1; i <= adet ; i++)
            {
                Console.Write(i + ". sayıyı giriniz: ");
                sayilar.Add(Console.ReadLine());

            }
            int tambolensayisi;
            string tambolenler;
            int deger;
            for (int  i = 0;  i< sayilar.Count; i++)
            {
                tambolensayisi = 0;
                tambolenler = "";
                deger = Convert.ToInt32(sayilar[i]);
                for (int j = 1; j <= deger; j++)
                {
                    if (deger%j==0)
                    {
                        tambolensayisi++;
                        if (deger == j) tambolenler = tambolenler + j;
                        else tambolenler = tambolenler + j + ",";
                    }

                }
                Console.WriteLine(deger + " sayısının tam bölen sayısı :" + tambolensayisi + "Tam bölenleri: " + tambolenler);
            }
            Console.ReadKey();
        }
    }
}
