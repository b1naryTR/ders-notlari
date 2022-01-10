using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notapp
{
    class Program
    {
        static void Main(string[] args)
        {
            double ort, sozlunot1, sozlunot2, yazilinot1, yazilinot2;
            Console.Write("Öğrencinin 1. sözlü notunu giriniz : ");
            sozlunot1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Öğrencinin 2. sözlü notunu giriniz : ");
            sozlunot2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Öğrencinin 1. yazılı notunu giriniz : ");
            yazilinot1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Öğrencinin 2. yazılı notunu giriniz : ");
            yazilinot2 = Convert.ToDouble(Console.ReadLine());
            ort = (yazilinot1 + yazilinot2 + sozlunot1 + sozlunot2) / 4;
            Console.Write("Öğrencinizin not ortalaması : " + ort);
            Console.ReadKey(); 
            

        }
    }
}
