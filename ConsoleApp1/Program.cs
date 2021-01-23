using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim Gelistirici Yetistirme Kampı";
            string kurs2 = "Programlamaya baslangic icin temel kurs";
            string kurs3 = "Java kursu";
            string kurs4 = "Python";
            string kurs5 = "C++";
         
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            //array-dizi
            string[] kurslar = new string[] {"Yazilim Gelistirici Yetistirme Kampı",
            "Programlamaya baslangic icin temel kurs",
            "Java kursu", "Python", "C#" };

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("ilk for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu-footer");
            Console.ReadKey();
        }
    }
}
