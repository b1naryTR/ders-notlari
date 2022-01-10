using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, i;

            Console.Write("Kaça gider dönmesini istediğiniz sayıyı giriniz.");

            sayi = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= sayi; i++)

            {

                Console.WriteLine(i);





            }



            Console.ReadKey();
        }
    }
}
