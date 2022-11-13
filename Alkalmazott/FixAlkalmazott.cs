using System;
using System.Collections.Generic;
using System.Text;

namespace Alkalmazott
{
    public class FixAlkalmazott : Alkalmazott
    {
        public FixAlkalmazott(double fizetes)
        {
            Fizetes = fizetes; 
        }
        public double Fizetes { get; private set; }
        public override string ToString()
        {
            return $"Nev {this.Nev}, Eletkor: {this.Eletkor}, Fizetes : {this.Fizetes} havonta ";
        }
    }
}
