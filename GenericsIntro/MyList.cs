using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor class new dersen otomatik çalışır
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            //Geçici dizi (array) elemanlar kaybolmaz geçici olarak tutturuldu artık arttırabiliriz
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }
    }
}
