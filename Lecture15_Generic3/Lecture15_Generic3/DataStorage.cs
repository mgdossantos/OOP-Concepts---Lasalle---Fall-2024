using System;
using System.Collections.Generic;
using System.Linq;

/*LINQ, which stands for Language Integrated Query, is a powerful feature in C# 
 * that allows developers to perform query operations directly in the language. 
 * It provides a consistent way to query and manipulate data from various data 
 * sources, such as collections, databases, XML, and more, using a syntax that 
 * is similar to SQL.*/

namespace Lecture15_Generic3
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

                foreach (T item in items)
                {
                    Console.WriteLine(item);
                }
            }

            // Expose items as IEnumerable<T> for LINQ support
            public IEnumerable<T> Items => items;
        }
   
}
