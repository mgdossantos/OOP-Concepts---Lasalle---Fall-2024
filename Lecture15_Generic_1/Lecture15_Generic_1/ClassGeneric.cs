using System;
using System.Collections.Generic;


namespace Lecture15_Generic_1
{
    public class Pair<T,U>
    {
        public T First { get; set; }
        public U Second { get; set; }

        public override string ToString()
        {
            return $"[ {First}, {Second}]";
        }
    }
}
