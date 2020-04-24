using System;
using Exerc_Prop_136.Entities.Class;
using System.Collections.Generic;
namespace Exerc_Prop_136
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int taxPayers = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= taxPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char typeOfPeople = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if(typeOfPeople == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    TaxPayer taxpayer = new Individual(name, anualIncome, healthExpenditures);
                    list.Add(taxpayer);
                }
                else if (typeOfPeople == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    TaxPayer taxpayer = new Company(name, anualIncome, numberOfEmployees);
                    list.Add(taxpayer);
                }

            }

            Console.WriteLine("TAXES PAID:");
            double sum = 0.0;
            foreach (TaxPayer tp in list)
            {
                sum += tp.Tax();
                Console.WriteLine(tp.Name + ": $ " + tp.Tax());
            }
            Console.WriteLine("TOTAL TAXEX: $ " + sum );
            
        }
    }
}
