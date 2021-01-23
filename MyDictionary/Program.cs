using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyNewList<string> myNewList = new MyNewList<string>();
            myNewList.Add("England");
            myNewList.Add("USA");
            myNewList.Add("Germany");
            myNewList.Show();
            Console.ReadLine();

        }
    }
}
