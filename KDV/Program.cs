using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDV
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi, sonuc;
            Console.Write("Sayıyı Giriniz: ");
            sayi = Convert.ToDouble(Console.ReadLine());
            sonuc = sayi * 18 / 100;
            Console.WriteLine("sonuç= " + sonuc);
            Console.ReadKey();
        }
    }
}
