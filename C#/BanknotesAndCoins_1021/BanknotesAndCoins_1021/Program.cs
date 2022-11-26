using System;

class URI
{

    static void Main(string[] args)
    {

        // Read a value of floating point with two decimal places

        decimal readValue = decimal.Parse(Console.ReadLine());

        // After this, calculate the smallest possible number of notes and coins on which the value can be decomposed
        // The considered notes are of 100, 50, 20, 10, 5, 2. The possible coins are of 1, 0.50, 0.25, 0.10, 0.05 and 0.01

        // Print the message “NOTAS:” followed by the list of notes

        Console.WriteLine("NOTAS:");

        decimal[] notesAndCoins = { 100m, 50m, 20m, 10m, 5m, 2m, 1m, 0.50m, 0.25m, 0.10m, 0.05m, 0.01m };

        foreach (decimal noteOrCoin in notesAndCoins) {

            if (noteOrCoin > 1) {

                decimal numberOfNotes = Math.Floor(readValue / noteOrCoin);
                readValue -= noteOrCoin * numberOfNotes;

                Console.WriteLine($"{numberOfNotes} nota(s) de R$ {noteOrCoin:F2}");

            } else {

                if (noteOrCoin == 1) { Console.WriteLine("MOEDAS:"); }

                decimal numberOfCoins = Math.Floor(readValue / noteOrCoin);
                readValue -= noteOrCoin * numberOfCoins;

                Console.WriteLine($"{numberOfCoins} moeda(s) de R$ {noteOrCoin:F2}");

            }

        }

    }

 }
