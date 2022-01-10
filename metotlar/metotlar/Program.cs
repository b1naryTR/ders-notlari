using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    class Program
    {
        static void metot1()
        {
            Console.WriteLine("Parametresi olmayan ve dönüş tipi olmayan metot");
        }
        static void metot2(int gelen_sayi)
        {
            Console.WriteLine("Gelen Değer: " + gelen_sayi);
        }
        static int metot3()
        {
            return 10;
        }
        static int metot4(int gelen_sayi)
        {
            return gelen_sayi;
        }
        static void Main(string[] args)
        {
            //metot1();
            //metot2(15);
            //int gelen_sayi=metot();
            //Console.Writeline("Gelen Sayı: " + gelen_sayi);
            int gelen_deger = metot4(20);
            Console.WriteLine("Gelen Sayı: " + gelen_deger);
            Console.ReadKey();
            
        }
    }
}
