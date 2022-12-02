using System;

class URI {

    static void Main(string[] args) {

        decimal salary = decimal.Parse(Console.ReadLine());
        decimal newSalary, earn;
        int percentage;

        if (salary >= 0 && salary <= 400) { 
            newSalary = salary + (salary * 0.15m);
            earn = salary * 0.15m;
            percentage = 15;
        } else if (salary > 400 && salary <= 800) {
            newSalary = salary + (salary * 0.12m);
            earn = salary * 0.12m;
            percentage = 12;
        } else if (salary > 800 && salary <= 1200) {
            newSalary = salary + (salary * 0.10m);
            earn = salary * 0.10m;
            percentage = 10;
        } else if (salary > 1200 && salary <= 2000) {
            newSalary = salary + (salary * 0.07m);
            earn = salary * 0.07m;
            percentage = 7;
        } else {
            newSalary = salary + (salary * 0.04m);
            earn = salary * 0.04m;
            percentage = 4;
        }

        Console.WriteLine(
                $"Novo salario: {newSalary:F2}\n" +
                $"Reajuste ganho: {earn:F2}\n" +
                $"Em percentual: {percentage} %"
                );

    }

}