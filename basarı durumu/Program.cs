using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basarı_durumu
{
    class Program
    {
        static void Main(string[] args)
        {
            int not1,not2,ort;
            Console.Write("1. notunuzu giriniz: ");
            not1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. notunuzu giriniz: ");
            not2 = Convert.ToInt16(Console.ReadLine());
            ort = (not1 + not2) / 2;
            if (ort >= 0 && ort < 25)
                Console.Write("Ortalamanız: " + ort + "\nNotunuz: 0" + "\nDurum = Kaldı");
            else if(ort >= 25 && ort < 45)
                Console.Write("Ortalamanız: " + ort + "\nNotunuz: 1" + "\nDurum = Başarısız");
            else if (ort >= 45 && ort < 55)
                Console.Write("Ortalamanız: " + ort + "\nNotunuz: 2" + "\nDurum = Geçti");
            else if (ort >= 55 && ort < 70)
                Console.Write("Ortalamanız: " + ort + "\nNotunuz: 3" + "\nDurum = Orta");
            else if (ort >= 70 && ort < 85)
                Console.Write("Ortalamanız: " + ort + "\nNotunuz: 4" + "\nDurum = İyi");
            else if(ort >= 85  && ort < 101)
                Console.Write("Ortalamanız: " + ort + "\nNotunuz: 5" + "\nDurum = Pek İyi");
            Console.ReadKey();

        }   
    }  
}
