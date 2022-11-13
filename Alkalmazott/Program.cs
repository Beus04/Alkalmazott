using System;

namespace Alkalmazott
{
    class Program
    {
        static void Main(string[] args)
        {
            var alkalmazott = new FixAlkalmazott(150000) { Nev = "Bela", Eletkor=25};
            var contractor = new Contractor(10000) { Nev ="Krisztian", Eletkor=45};

            Console.WriteLine(alkalmazott);
            Console.WriteLine(contractor);
        }
    }
}
