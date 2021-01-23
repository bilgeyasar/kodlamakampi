using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {/*
            string urunadi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elmasi"; */

            string[] meyveler = new string[] {"elma","karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};

            //type-safe
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----");
                
            }
           
           
            Console.WriteLine("-----Metotlar-----");

            //instance-örnek
            //stok adedi eklediğimizde- encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "armut aciklama", 12,5);
            sepetManager.Ekle2("Elma", "elma aciklama", 12,6);
            sepetManager.Ekle2("Karpuz", "karpuz aciklama", 12,7);
                        
        }
    }
}

//Don't repeat yourself - DRY - Clean Code - Best Practice 
