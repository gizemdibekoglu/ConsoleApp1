﻿using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklma = "Amasya Elmasi";

            string[] meyveler = new string[] {"elma","karpuz" };
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır karpuzu";

            Urun[] urunler = new Urun[]{urun1,urun2};
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("________________________________");

            }

            Console.WriteLine("------------METODLAR-----------------");

            /*instance -örnek
            encapsulation*/
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil armut", 12,10);
            sepetManager.Ekle2("elma", "yeşil elma", 12, 20);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 12, 25);
        }
    }
}
