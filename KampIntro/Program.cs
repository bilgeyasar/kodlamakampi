using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety
            //Do not repeat yourself

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if(dolarDun<dolarBugun)
            {
                Console.WriteLine("azalıs butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artıs butonu");
            }
            else
            {
                Console.WriteLine("azalis butonu");
            }

            if (sistemeGirisYapmisMi ==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("giris yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
            Console.ReadKey();
        }
    }
}
