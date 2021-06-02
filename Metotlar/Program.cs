using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urün urun1 = new Urün();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urün urun2 = new Urün();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            Urün[] urunler = new Urün[] {urun1,urun2};

            foreach (Urün urun in urunler)
              
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("--------------------METOTLAR-----------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut","yeşil armut",12);
            sepetManager.Ekle2("elma", "yeşil elma", 42);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 25);



        }
    }
}
