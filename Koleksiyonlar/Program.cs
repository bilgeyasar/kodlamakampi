using System;
using System.Collections.Generic;  //Listten geldi

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        { /*
            //stack            //heap
            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler = new string[5]; //new diyince yeni adres oluşur boş array gelir
            isimler[4] = "İlker";
            Console.WriteLine(isimler[4]);   */

            // Console.WriteLine(isimler[0]); //boş geliyor Engin ama geliyor
            //Yeni eleman eklerken datadan geldiğinden sonradan ekleme yapamadığımız için
            //array değil collections kullanıyoruz. 4 elemanlı array'i 5 yapamıyoruz.
            //PS: Bellekte stack ve heap var referans tipler ikisini değer tipler sadece stack
            //Değişken kısmı stackte mesela isimler.
            //new dediğimiz an heap'te 4 elemanlı bir yer oluştur demek
            //isimler adresi 101 ise isimler= new string[5] diyince yeni adres oluyo(102).
            //isimler[4]="İlker" 102 idi. isimlerin adresi 102 oldu.


            List<string> isimler2 = new List<string> {"Engin","Murat","Kerem","Halil"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);        
            Console.WriteLine(isimler2[0]);


            Console.ReadKey();
        }
    }
}
