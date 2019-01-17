using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections.Classes
{
    public class Deck<T> : IEnumerable<T>
    {

        public T[] internalItems = new T[10];
        public int currentIndex = 0;

        public void Add(T item)
        {
            if (currentIndex > internalItems.Length - 1)
            {
                Array.Resize(ref internalItems, internalItems.Length * 2);
            }

            internalItems[currentIndex] = item;
            currentIndex++;

        }
        public void RemoveCards()
        {
            Array.Resize(ref internalItems, internalItems.Length - (currentIndex - 1));

            
        }
        
       public void CardsInDeck()
        {
            Console.WriteLine(currentIndex);
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                yield return internalItems[i];
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();

        }
    }
}
