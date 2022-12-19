using System;

class URI {

    static void Main(string[] args) {

        int fuelOption = 0;
        int alcohol = 0;
        int gasoline = 0;
        int diesel = 0;

        do {

            fuelOption = int.Parse(Console.ReadLine());

            switch(fuelOption) {
                case 1:
                    alcohol++; break;
                case 2:
                    gasoline++; break;
                case 3:
                    diesel++; break;
                default: break;
            }

        } while(fuelOption != 4);

        Console.WriteLine(
            $"MUITO OBRIGADO\n" +
            $"Alcool: {alcohol}\n" +
            $"Gasolina: {gasoline}\n" +
            $"Diesel: {diesel}");

    }

}