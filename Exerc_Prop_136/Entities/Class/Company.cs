using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_Prop_136.Entities.Class
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }
    
        public Company()
        {

        }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public sealed override double Tax()
        {
            double tax;
            if (NumberOfEmployees < 10)
            {
                tax = AnualIncome * 0.16;
            }
            else
            {
                tax = AnualIncome * 0.14;
            }     
                return  tax;
        }
    }
}
