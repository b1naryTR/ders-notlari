using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev3
{
    class Program
    {
        static void Main(string[] args)
        {
            int baslangic, bitis, i;
            Console.Write("Döngünün başlamasını istediğiniz başlangıç değerini giriniz.");
            baslangic = Convert.ToInt32(Console.ReadLine());
            Console.Write("Döngünün bitmesini istediğiniz bitiş değerini giriniz.");
            bitis = Convert.ToInt32(Console.ReadLine());
            if (baslangic < bitis)
            {
                for (i = baslangic; i <= bitis; i++)
                {
                    Console.WriteLine(i);

                }
            }
            else
            {
                for (i = baslangic; i >= bitis; i--)
                {
                    Console.WriteLine(i);

                }
            }

            Console.ReadKey();
        }
    }
}
