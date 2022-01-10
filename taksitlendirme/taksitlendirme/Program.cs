using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taksitlendirme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double taksit, satis, miktar;
            Console.Write("Ürünün satış fiyatını giriniz:");
            satis = Convert.ToDouble(Console.ReadLine());
        kntrl:
            Console.Write("Taksit sayısını giriniz:");
            taksit = Convert.ToDouble(Console.ReadLine());
            if (taksit > 12 || taksit <= 0)
            {
                Console.WriteLine("Taksit sayısı 1'den 12'ye kadar olmalıdır.");
                goto kntrl;
            }
            else
            {
                miktar = satis / taksit;
                for (int i = 1; i <= taksit; i++)
                {
                    Console.WriteLine(i + ". Taksit : " + miktar);
                }

            }

            Console.ReadKey();
        }
    }
}
