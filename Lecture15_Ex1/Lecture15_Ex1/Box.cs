using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture15_Ex1
{
    public class Box<T>
    {
        private T item;

        public void SetItem(T newItem)
        {
            item=newItem;
        }

        public T GetItem()
        {
            return item;
        }

        public void DisplayItem()
        {
            Console.WriteLine($"Item: {item}");
        }
    }
}
