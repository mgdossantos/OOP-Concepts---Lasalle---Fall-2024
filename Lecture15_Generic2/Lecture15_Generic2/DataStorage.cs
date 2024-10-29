using System;
using System.Collections.Generic;


namespace Lecture15_Generic2
{
    public class DataStorage<T>
    {
        private List<T> items = new List<T>();

        // Add an item of type T
        public void addItem(T item)
        {
            items.Add(item);
            Console.WriteLine($"{item} added to storage");
        }

        // Retrieve an item at a specific index
        public T getItem(int index)
        {
            return items[index];
        }


        // Display all items in storage
        public void displayItems()
        {
        
            foreach(T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
