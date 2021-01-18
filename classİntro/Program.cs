using System;

namespace classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "gizem";
            int yas = 24;

            kurs kurs1 = new kurs(); // senin artık kurs in var tipi kurs
            kurs1.kursAdı = "c#";
            kurs1.Egitmen = "Engin DEMİROG";
            kurs1.İzlenmeOranı = 68;


            kurs kurs2 = new kurs(); // senin artık kurs in var tipi kurs
            kurs2.kursAdı = "java";
            kurs2.Egitmen = "Eray";
            kurs2.İzlenmeOranı = 80;


            kurs kurs3 = new kurs(); // senin artık kurs in var tipi kurs
            kurs3.kursAdı = "phyton";
            kurs3.Egitmen = "berkay";
            kurs3.İzlenmeOranı = 70;

            // Console.WriteLine(kurs1.kursAdı + " " + kurs1.Egitmen);

            kurs[] kurslar = new kurs[] {kurs1,kurs2,kurs3 }; // new kurs yazarsan içinde kurs tutarsın new string yazarsan sadece string ttarsın
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdı);
            }
            Console.WriteLine("Hello World!");
        }
    }

    class kurs
    { //değişkenimiz strinden kursa döndü yani string gibi bir değişken oluşturdum.KursAdı ,Egitmen,izlenme oranı birer değişken oldu Bunları bir arada tutan tip tanımladım.
        public string  kursAdı { get; set; }
        public string  Egitmen { get; set; }
        public int İzlenmeOranı { get; set; }
    }
}
