using System;
using System.Collections.Generic;
using System.Text;

namespace Alkalmazott
{
    public class Contractor : Alkalmazott
    {
        public Contractor(double oraber)
        {
            Oraber = oraber;
        }
        public double Oraber { get; set; }

        public override string ToString()
        {
            return $"Nev {this.Nev}, Eletkor: {this.Eletkor}, Fizetes : {this.Oraber} orankent ";
        }
    }
}
