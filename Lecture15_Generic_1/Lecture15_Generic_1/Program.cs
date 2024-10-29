using System;

namespace Lecture15_Generic_1
{

    public class Program
    {
        public static void Main(string[] args)
        {
            /*PairIntInt pairIntInt = new PairIntInt();*/
            Pair<int,int> pairIntInt = new Pair<int,int>();
            pairIntInt.First = 5;
            pairIntInt.Second = 8;

            Console.WriteLine(pairIntInt.ToString());

            /*PairIntFloat pairIntFloat = new PairIntFloat();*/
            Pair<int,float> pairIntFloat = new Pair<int,float>();
            pairIntFloat.First = 5;
            pairIntFloat.Second = 8.5f;

            Console.WriteLine(pairIntFloat.ToString());

            /*PairStringString pairStringString = new PairStringString();*/
            Pair<string,string> pairStringString = new Pair<string,string>();

            pairStringString.First = "Marcela";
            pairStringString.Second = "Rafaela";

            Console.WriteLine(pairStringString.ToString());

        }
    }
}