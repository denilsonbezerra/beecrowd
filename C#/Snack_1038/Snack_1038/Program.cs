using System;

class URI {

    static void Main(string[] args) {

        // Using the following table, write a program that reads a code and the amount of an item
        // 1 - Cachorro Quente - 4,00
        // 2 - X-Salada - 4,50
        // 3 - X-Bacon - 5,00
        // 4 - Torrada Simples - 2,00
        // 5 - Refrigerante - 1,50
        // After, print the value to pay

        string[] readLine = Console.ReadLine().Split();

        int itenCode = int.Parse(readLine[0]);
        int itenAmount = int.Parse(readLine[1]);

        decimal itenPrice = 0;
        decimal valueToPay = 0;

        if (itenCode == 1) {

            itenPrice = 4.00M;
            valueToPay = itenPrice * itenAmount;

            Console.WriteLine($"Total: R$ {valueToPay:F2}");

        } else if (itenCode == 2) {

            itenPrice = 4.50M;
            valueToPay = itenPrice * itenAmount;

            Console.WriteLine($"Total: R$ {valueToPay:F2}");

        } else if (itenCode == 3) {

            itenPrice = 5.00M;
            valueToPay = itenPrice * itenAmount;

            Console.WriteLine($"Total: R$ {valueToPay:F2}");

        } else if (itenCode == 4) {

            itenPrice = 2.00M;
            valueToPay = itenPrice * itenAmount;

            Console.WriteLine($"Total: R$ {valueToPay:F2}");

        } else if (itenCode == 5) {

            itenPrice = 1.50M;
            valueToPay = itenPrice * itenAmount;

            Console.WriteLine($"Total: R$ {valueToPay:F2}");

        }

    }

}