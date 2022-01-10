using System;

namespace Try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { int yas;
                Console.Write("Yaş: ");
                yas = Convert.ToInt16(Console.ReadLine());
                Console.Write("Yaşınız: " + yas);

            }
            catch(Exception err)
            {
                Console.WriteLine("Hata Mesajı: " + err.Message);
            }
            finally
            {
                Console.Write("Yine Çalıştı.");
            }

            Console.ReadKey();
        }

    }
}
