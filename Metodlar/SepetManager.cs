using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("tebrikler.sepete eklendi: " + urun.Adi);
        }

        public void Ekle2(string urunAdi,string Aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("tebrikler.sepete eklendi: " + urunAdi);
        }
    }
}
