using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayısı = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapildiMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış İşareti");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış İşareti");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }
            
            if (sistemeGirisYapildiMi == true)
            {
                Console.WriteLine("Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
              Console.WriteLine(kategoriEtiketi);
                




            
        }
    }
}
