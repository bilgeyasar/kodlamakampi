using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList() //ctor diyince
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            //referans nosu gitmesin diye tempArray items'in referansını tutuyo
            T[] tempArray = items;
            //items.Length eleman sayısını verir
            items = new T[items.Length+1];  //mevcut eleman sayımı 1 arttır
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
