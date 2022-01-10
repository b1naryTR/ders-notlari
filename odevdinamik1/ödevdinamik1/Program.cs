using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ödevdinamik1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList sayilar = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                Console.Write((i + 1) + ".Sayıyı Giriniz: ");
                sayilar.Add(Console.ReadLine());
            }
            int kontrol;
            for (int i = 0; i < sayilar.Count; i++)
            {
                int deger = Convert.ToInt32(sayilar[i]);
                kontrol = 0;
                for (int j = 1; j <= deger; j++)
                {
                    if (deger % j == 0) kontrol++;
                }
                if (kontrol > 2 || deger <=1) Console.WriteLine(deger + "-> Asal Değildir");
                else Console.WriteLine(deger + "-> Asaldır");
            }
            Console.ReadKey();
           
        }
    }
}
