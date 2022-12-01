using System;

class URI
{

    static void Main(string[] args)
    {

        decimal inputValue = decimal.Parse(Console.ReadLine());

        Console.WriteLine("NOTAS:");

        decimal[] notesAndCoins = { 100m, 50m, 20m, 10m, 5m, 2m, 1m, 0.50m, 0.25m, 0.10m, 0.05m, 0.01m };

        foreach (decimal noteOrCoin in notesAndCoins) {

            decimal notesAndCoinsNum = Math.Floor(inputValue / noteOrCoin);
            inputValue -= noteOrCoin * notesAndCoinsNum;

            if (noteOrCoin > 1) {
                Console.WriteLine($"{notesAndCoinsNum} nota(s) de R$ {noteOrCoin:F2}");
            } else {
                if (noteOrCoin == 1) { Console.WriteLine("MOEDAS:"); }
                Console.WriteLine($"{notesAndCoinsNum} moeda(s) de R$ {noteOrCoin:F2}");
            }

        }

    }

 }
