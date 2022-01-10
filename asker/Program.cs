




























using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asker
{
    class Program
    {
        static void Main(string[] args)
        {
        askerlik:
            Console.Clear();
            char cinsiyet;
            Console.Write("Cinsiyetiniz Nedir(E/K): ");
            cinsiyet = Convert.ToChar(Console.ReadLine());
            if(cinsiyet == 'E' || cinsiyet == 'e')
            {
                int yas;
                Console.Write("Yaşınızı Giriniz: ");
                yas = Convert.ToInt32(Console.ReadLine());
                if(yas>=20)
                {
                    Console.WriteLine("Askere Gidebilirsiniz.");
                }
                else
                {
                    Console.WriteLine("Yaşınızdan Dolayı Askere Gidemezsiniz.");
                }

            }
            else
            {
                Console.WriteLine("Cinsiyetinizden Dolayı Askere Gidemezsiniz.");
            }
            Console.Write("Tekrar Sorgulamak İster misiniz (E/e)");
            char kontrol = Convert.ToChar(Console.ReadLine());
            if (kontrol == 'E' || kontrol == 'e')
            {
                goto askerlik;
            }
            Console.ReadKey();
        }
    }
}
