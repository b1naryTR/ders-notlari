using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Karesini almak İstediğiniz Sayıyı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sonuc = sayi * sayi;
            Console.WriteLine(sayi + " sayısının karesi : " + sonuc);
            
            Console.ReadKey();
        }
    }
}
