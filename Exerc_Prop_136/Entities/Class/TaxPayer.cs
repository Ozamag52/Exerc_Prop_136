using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_Prop_136.Entities.Class
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }
    
        public TaxPayer()
        {

        }
        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();

    }
}
