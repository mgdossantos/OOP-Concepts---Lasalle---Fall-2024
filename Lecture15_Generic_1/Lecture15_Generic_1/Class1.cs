using System;


namespace Lecture15_Generic_1
{
    public class PairIntInt
    {
        public int First { get; set; }
        public int Second { get; set; }

        public override string ToString()
        {
            return $"( {First}, {Second})";
        }

    }

    public class PairIntFloat
    {
        public int First { get; set; }
        public float Second { get; set; }

        public override string ToString()
        {
            return $"( {First}, {Second})";
        }

    }

    public class PairStringString
    {
        public string First { get; set; }
        public string Second { get; set; }

        public override string ToString()
        {
            return $"[ {First}, {Second}]";
        }

    }
}
