using System;
using System.Globalization;

public class TaxPayer {
    public double salaryIncome { get; set; }
    public double servicesIncome { get; set; }
    public double capitalIncome { get; set; }
    public double healthSpending { get; set; }
    public double educationSpending { get; set; }

    public TaxPayer(double salaryincome, double servicesincome, double capitalincome, double healthspending, double educationspending) {
        salaryIncome = salaryincome;
        servicesIncome = servicesincome;
        capitalIncome = capitalincome;
        healthSpending = healthspending;
        educationSpending = educationspending;
    }

    public double salaryTax() {
        double monthlySalary = salaryIncome / 12;
        if (monthlySalary < 3000) return 0;
        if (monthlySalary < 5000) return salaryIncome * 0.10;
        return salaryIncome * 0.20;
    }

    public double servicesTax() {
        return servicesIncome * 0.15;
    }

    public double capitalTax() {
        return capitalIncome * 0.20;
    }

    public double grossTax() {
        return salaryTax() + servicesTax() + capitalTax();
    }

    public double taxRebate() {
        double maxRebate = grossTax() * 0.30;
        double totalSpending = healthSpending + educationSpending;
        return totalSpending < maxRebate ? totalSpending : maxRebate;
    }

    public double NetTax() {
        return grossTax() - taxRebate();
    }

    public override string ToString() {
        return $"Imposto bruto total: {grossTax().ToString("F2", CultureInfo.InvariantCulture)}\n" +
               $"Abatimento: {taxRebate().ToString("F2", CultureInfo.InvariantCulture)}\n" +
               $"Imposto devido: {NetTax().ToString("F2", CultureInfo.InvariantCulture)}\n";
    }
}
