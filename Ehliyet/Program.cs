using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ehliyet
{
    class Program
    {
        static void Main(string[] args)
        {
            int yas;
            Console.Write("Yaşınızı Giriniz: ");
            yas = Convert.ToInt32(Console.ReadLine());
            if(yas>=18)
            {
                Console.Write("Ehliyet Alabilirsiniz.");
            }
            else
            {
                Console.Write("Ehliyet Alamazsınız.");
            }
            Console.ReadKey();

        }
    }
}
