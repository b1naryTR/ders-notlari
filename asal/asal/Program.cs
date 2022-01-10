using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asal
{
    class Program
    {
        static void Main(string[] args)
        {
            int kontrol = 0;
            Console.Write("Sayı girin.");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                    kontrol++;
            }
            if (kontrol != 0)
                Console.Write("Bu sayı asal değildir.");
            else
                Console.Write("Bu sayı asaldır.");
            Console.ReadKey();
        }
    }
}
