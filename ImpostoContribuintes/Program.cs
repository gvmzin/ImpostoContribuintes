using System;
using System.Collections.Generic;
using ImpostoContribuintes.Entities;


namespace ImpostoConstribuintes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare o numero de contribuintes    
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            List<Contribuinte> list = new List<Contribuinte>();

            // Loop para ler os dados de cada contribuinte
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i+1} data: ");
                Console.Write("Individual or company(i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine());
                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    Contribuinte c = new PessoaFisica(name, income, healthExpenditures);
                    list.Add(c);

                }
                else
                {
                    Console.Write("Number of employees: ");
                    double numberOfEmployees = double.Parse(Console.ReadLine());
                    Contribuinte c = new PessoaJuridica(name, income, numberOfEmployees);
                    list.Add(c);
                }


            }
            // Imprime os dados dos contribuintes
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (Contribuinte c in list)
            {
                Console.WriteLine(c.Name + ": $ " + c.Tax().ToString("F2"));
            }
            double sum = 0.0;
            foreach (Contribuinte c in list)
            {
                sum += c.Tax();
            }
        }
    }
}
