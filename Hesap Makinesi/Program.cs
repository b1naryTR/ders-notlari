using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Makinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1_giris, sayi2_giris;
            double sonuc;
            string islem;
            Console.WriteLine("Birinci sayıyı girin:");
            sayi1_giris = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı girin:");
            sayi2_giris = Convert.ToInt32(Console.ReadLine());
            baslangic:
            Console.WriteLine("İşlem seçin(*,/,+,-,%)");
            islem = Console.ReadLine();
            if (islem == "*")
            {
                sonuc = sayi1_giris * sayi2_giris;
                Console.WriteLine("Sonuç: " + sonuc);
            }
            else if(islem == "/")
            {
                sonuc = sayi1_giris / sayi2_giris;
                Console.WriteLine("Sonuç: " + sonuc);
            }
            else if(islem == "+")
            {
                sonuc = sayi1_giris + sayi2_giris;
                Console.WriteLine("Sonuç: " + sonuc);
            }
            else if(islem == "-")
            {
                sonuc = sayi1_giris - sayi2_giris;
                Console.WriteLine("Sonuç: " + sonuc);
            }
            else if (islem == "%")
            {
                sonuc = sayi1_giris % sayi2_giris;
                Console.WriteLine("Sonuç: " + sonuc);
            }
            else
            {
                char kontrol;
                Console.Write("yanlış bir değer girdiniz. Tekrar denemek ister misiniz?(E/e): ");
                kontrol = Convert.ToChar(Console.ReadLine());
                if(kontrol=='E' || kontrol == 'e')
                {
                    goto baslangic;
                }

            }
            Console.ReadKey();

        }
    }
}
