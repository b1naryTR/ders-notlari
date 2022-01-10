using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dallanmalar
{
    class Program
    {
        static void Main(string[] args)
        {   //break örneği
            /*
            for(int i=1;i<=10;i++)
            {

                Console.WriteLine(i);
                if (i == 5) break;
            }
            */

            //continue örneği
            /*
            for(int i=1;i<=10;i++)
            {
                if (i == 5) continue;
                Console.WriteLine(i);

            }
            */

            /*
            baslangic:
                Console.Clear();
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
                Console.Write("Tekrar Yazdırmak İster misiniz (E/e)");
                char kontrol = Convert.ToChar(Console.ReadLine());
                if(kontrol=='E' || kontrol=='e')
                {
                    goto baslangic;
                }
            */

            /*
            for(int i=65;i<=90;i++)
            {
                Console.WriteLine(Convert.ToChar(i));

            }
            */
            // break örneği-2
            /*char krktr;
            for (int i=65;i<=90;i++)
            {
                krktr = Convert.ToChar(i); 
                if ( krktr == 'K')
                {
                    break;
                }
                Console.WriteLine(Convert.ToChar(i));



            }

            Console.ReadKey();
            */
            
        }
    }
}
