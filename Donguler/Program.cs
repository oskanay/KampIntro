using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı",
            "Programlamaya başlangıç için temel kurs",
            "Java-React"};


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("Sayfa sonu-footer");
        }
         foreach (string kurs in kurslar)       
	     {
          Console.WriteLine(kurs);
	     }
    }
}
