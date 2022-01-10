using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıf_mevcudu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mevcut = { "fatih", "harun", "mustafa", "mevlüt", "burak", "dara", "demir", "onur", "aziz", "kerem" };
            int sira = 1;
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine(sira + ". Öğrenci -" + mevcut[i]);
                sira++;
            }
            Console.ReadKey();
            
        }
    }
}
