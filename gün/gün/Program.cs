using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gün
{
    class Program
    {
        static void Main(string[] args)
        {
            int gun;
            Console.Write("Kaçıncı gün olduğunu giriniz:");
            gun = Convert.ToInt32(Console.ReadLine());
            if(gun<=0||gun>7)
            {
                Console.Write("1'den 7'ye kadar olan bir sayı giriniz.");
            }
            else
            {
                if (gun == 1)
                        Console.Write("Pazartesi");
                else if(gun==2)
                        Console.Write("Salı");
                else if (gun == 3)
                        Console.Write("Çarşamba");
                else if (gun == 4)
                        Console.Write("Perşembe");
                else if (gun == 5)
                        Console.Write("Cuma");
                else if (gun == 6)
                        Console.Write("Cumartesi");
                else
                        Console.Write("Pazar");


            }
            Console.ReadKey();
        }
    }
}
