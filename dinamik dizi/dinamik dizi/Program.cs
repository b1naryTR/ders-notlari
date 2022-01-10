using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace dinamik_dizi
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ddizi = new ArrayList();
            ddizi.Add(1);
            ddizi.Add('A');
            ddizi.Add(1.4);
            ddizi.Add(111);
            ddizi.Add("Abc");
            ddizi.Add("7xy");
            ddizi.Add(3);
            int elemansayisi = ddizi.Count;
            Console.WriteLine("Dizinin İlk Hali");
            for (int i = 0; i < elemansayisi; i++)
            {
                Console.WriteLine(i + "->" + ddizi[i]);
            }
            Console.WriteLine("Eleman Sayısı: " + elemansayisi);
            ddizi.Insert(5, 123);
            ddizi.Remove(111);
            ddizi.Remove("7xy");
            ddizi.RemoveAt(3);
            int yenielemansayisi = ddizi.Count;
            Console.WriteLine("----------------");
            Console.WriteLine("Dizinin Son Hali");
            for (int i = 0; i < yenielemansayisi; i++)
            {
                Console.WriteLine(i + "->" + ddizi[i]);
            }
            Console.WriteLine("Eleman Sayısı: " + yenielemansayisi);
            Console.ReadKey();


        }
    }
}
