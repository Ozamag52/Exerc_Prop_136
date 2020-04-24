using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_Prop_136.Entities.Class
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }
        public Individual()
        {

        }
        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public sealed override double Tax()
        {
            double tax;
            if(AnualIncome < 20000.00)
            {
                tax = AnualIncome * 0.15;
            }
            else
            {
                tax = AnualIncome * 0.25;
            }

            if (HealthExpenditures > 0.00)
            {
                double abat = HealthExpenditures * 0.5;
                return AnualIncome - (tax - abat);
            }
            else 
            { 
                return AnualIncome - tax;
            }
        }

    }
}
