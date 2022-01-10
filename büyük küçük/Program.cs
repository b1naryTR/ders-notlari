using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace büyük_küçük
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1,sayi2;
            Console.Write("1. sayıyı giriniz: ");
            sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. sayıyı giriniz: ");
            sayi2 = Convert.ToInt16(Console.ReadLine());
            if(sayi1>sayi2)
            {
                Console.Write(sayi1 + " " + sayi2 + " 'den büyüktür.");
            }
            else if(sayi1<sayi2)
            {
                Console.Write(sayi1 + " " + sayi2 + " 'dan küçüktür.");
            }
            else
            {
                Console.Write(sayi1 + " " + sayi2 + " 'ye eşittir.");
            }
            Console.ReadKey();
        }
    }
}
