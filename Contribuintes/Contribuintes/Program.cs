using System;
using System.Collections.Generic;
using System.Globalization;

namespace Contribuintes {
    public class Program {
        public static void Main(string[] args) {
            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Quantos Contribuintes você vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Digite dados do contribuinte #{i + 1}:");

                Console.Write("Renda anual com salário: ");
                double salaryIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Renda anual com prestação de serviço: ");
                double servicesIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Renda anual com ganho de capital: ");
                double capitalIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Gastos médicos: ");
                double healthSpending = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Gastos educacionais: ");
                double educationSpending = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                taxPayers.Add(new TaxPayer(salaryIncome, servicesIncome, capitalIncome, healthSpending, educationSpending));
            }

            Console.WriteLine("\nRESUMO DOS IMPOSTOS:");
            for (int i = 0; i < taxPayers.Count; i++) {
                Console.WriteLine($"Resumo do {i + 1}º contribuinte:");
                Console.WriteLine(taxPayers[i]);
            }
        }
    }
}
