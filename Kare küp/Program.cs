using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kare_küp
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, kontrol;
        baslangic:
            Console.Clear();
            Console.Write("Karesini veya küpünü hesaplamak istediğiniz sayıyı giriniz: ");
            sayi = Convert.ToInt16(Console.ReadLine());
            Console.Write("Karesi için 0 küpü için 1'e basın.");
            kontrol = Convert.ToInt16(Console.ReadLine());
            if(kontrol==0)
            {
                int sonuc = sayi * sayi;
                Console.WriteLine(sayi + " sayısının karesi : " + sonuc);
            }
            else if (kontrol == 1)
            {
                int sonuc = sayi * sayi * sayi;
                Console.WriteLine(sayi + " sayısının küpü : " + sonuc);
            }
            else
            {
                Console.Write("Lütfen geçerli bir sayı giriniz.");
            }
            Console.Write("Tekrar Denemek İster misiniz? (E/e)");
            char kont = Convert.ToChar(Console.ReadLine());
            if (kont == 'E' || kont == 'e')
            {
                goto baslangic;
            }
            Console.ReadKey();
        }
    }
}
