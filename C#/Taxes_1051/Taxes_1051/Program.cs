using System;

class URI {

    static void Main(string[] args) {

        decimal salary = decimal.Parse(Console.ReadLine());
        decimal taxes, taxes8, taxes18, taxes28;

        if (salary >= 0 && salary <= 2000) {
            Console.WriteLine("Isento");
        } else if (salary > 2000 && salary <= 3000) {

            taxes = (salary - 2000) * 0.08m;
            Console.WriteLine($"R$ {taxes:F2}");

        } else if (salary > 3000 && salary <= 4500) {

            taxes18 = salary - 3000;
            taxes8 = salary - taxes18 - 2000;
            taxes = taxes8 * 0.08m + taxes18 * 0.18m;

            Console.WriteLine($"R$ {taxes:F2}");
        
        } else {

            taxes28 = salary - 4500;
            taxes18 = salary - taxes28 - 3000;
            taxes8 = salary - taxes18 - taxes28 - 2000;
            taxes = taxes8 * 0.08m + taxes18 * 0.18m + taxes28 * 0.28m;

            Console.WriteLine($"R$ {taxes:F2}");

        }

    }

}