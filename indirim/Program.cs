using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discount
{
    class Program
    {
        static void Main(string[] args)
        {
            double tutar, indirimli_tutar, kalan;
            baslangic:
            Console.Clear();
            Console.Write("Alışveriş tutarınızı giriniz: ");
            tutar = Convert.ToDouble
                (Console.ReadLine());
            if(tutar>=100 && tutar<200)
            {
                Console.Write("İndirimsiz Tutar: " + tutar);
                Console.Write("\nİndirim Oranı: %10");
                indirimli_tutar = tutar - (tutar / 10);
                Console.Write("\nİndirimli Tutar : " + indirimli_tutar);
            }
            else if (tutar >= 200 && tutar < 300)
            {
                Console.Write("İndirimsiz Tutar: " + tutar);
                Console.Write("\nİndirim Oranı: %15");
                indirimli_tutar = tutar - (tutar * 15 / 100);
                Console.Write("\nİndirimli Tutar : " + indirimli_tutar);
            }
            else if (tutar >= 300)
            {
                Console.Write("İndirimsiz Tutar: " + tutar);
                Console.Write("\nİndirim Oranı: %20");
                indirimli_tutar = tutar - (tutar / 5);
                Console.Write("\nİndirimli Tutar : " + indirimli_tutar);
            }
            else
            {
                Console.Write("İndirimsiz Tutar: " + tutar);
                kalan = 100 - tutar;
                Console.Write("\nŞuanki tutar indirim için yeterli değil. İndirim için sepetinize " + kalan + " liralık bir ürün ekleyin.");  
            }
            Console.Write("\nTekrar Denemek İster misiniz? (E/e)");
            char kont = Convert.ToChar(Console.ReadLine());
            if (kont == 'E' || kont == 'e')
            {
                goto baslangic;
            }
            Console.ReadKey();
        }
    }
}
