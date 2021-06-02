using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urün urün)
        {
            Console.WriteLine("Sepete Eklendi." + urün.Adi);

        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat) {
            Console.WriteLine("Sepete Eklendi." + urunAdi);

        }
    }
}
