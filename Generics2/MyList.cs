﻿namespace Generics2
{
    public class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            // Referans adresini tutmak için
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
