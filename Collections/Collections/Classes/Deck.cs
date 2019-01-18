using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections.Classes
{
    /// <summary>
    /// Allows us to dynamically work with array
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Deck<T> : IEnumerable<T>
    {

        public T[] internalItems = new T[10];
        public int currentIndex = 0;


        /// <summary>
        /// This method adds items to list and resizes if need be
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            if (currentIndex > internalItems.Length - 1)
            {
                Array.Resize(ref internalItems, internalItems.Length * 2);
            }

            internalItems[currentIndex] = item;
            currentIndex++;

        }

        /// <summary>
        /// Will remove a card from the deck
        /// </summary>
        public void RemoveCards()
        {
           Array.Resize(ref internalItems, currentIndex - 1);
            currentIndex--;
        }
        
       
        /// <summary>
        /// This print the amount of cards in the deck
        /// </summary>
       public void CardsInDeck()
        {
            Console.WriteLine($"There are {currentIndex} left in deck");
        }

        /// <summary>
        /// Method from interface
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                yield return internalItems[i];
            }

        }
        /// <summary>
        /// Calls method from above
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();

        }
    }
}
