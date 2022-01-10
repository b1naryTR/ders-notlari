using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notapp2
{
    class Program
    {
        static void Main(string[] args)
        {

            double vizenot, finalnot, ort;
            Console.Write("Lütfen öğrencinin vize notunu giriniz. ");
            vizenot = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lütfen öğrencinin final notunu giriniz. ");
            finalnot = Convert.ToDouble(Console.ReadLine());
            ort = ((vizenot / 100) * 40) + ((finalnot / 100) * 60);s
            Console.Write("Öğrencinizin ortalaması : " + ort);
            Console.ReadKey();
        }
    }
}
