using System;

class URI {

    static void Main(string[] args) {

        string[] readLine = Console.ReadLine().Split();

        int itenCode = int.Parse(readLine[0]);
        int itenAmount = int.Parse(readLine[1]);

        decimal itenPrice = 0;

        switch (itenCode) {
            case 1:
                itenPrice = 4.00M; break;
            case 2:
                itenPrice = 4.50M; break;
            case 3:
                itenPrice = 5.00M; break;
            case 4:
                itenPrice = 2.00M; break;
            case 5:
                itenPrice = 1.50M; break;
            default: 
                break;
        }

        decimal valueToPay = itenPrice * itenAmount;

        Console.WriteLine($"Total: R$ {valueToPay:F2}");

    }

}
