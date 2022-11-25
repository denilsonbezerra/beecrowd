using System;

class URI
{

    static void Main(string[] args)
    {

        // Read a value of floating point with two decimal places

        decimal value = decimal.Parse(Console.ReadLine());

        // After this, calculate the smallest possible number of notes and coins on which the value can be decomposed
        // The considered notes are of 100, 50, 20, 10, 5, 2. The possible coins are of 1, 0.50, 0.25, 0.10, 0.05 and 0.01

        // Print the message “NOTAS:” followed by the list of notes

        int[] notes = { 100, 50, 20, 10, 5, 2 };

        Console.WriteLine("NOTAS:");
        
        foreach (int note in notes) {

            decimal numberOfNotes = Math.Floor(value / note);
            value -= note * numberOfNotes;

            Console.WriteLine($"{numberOfNotes} nota(s) de R$ {note:F2}");

        }

        // Print the message “MOEDAS:” followed by the list of coins

        decimal[] coins = { 1, 0.50M, 0.25M, 0.10M, 0.05M, 0.01M };

        Console.WriteLine("MOEDAS:");

        foreach (decimal coin in coins) {

            decimal numberOfCoins = Math.Floor(value / coin);
            value -= coin * numberOfCoins;

            Console.WriteLine($"{numberOfCoins} moeda(s) de R$ {coin:F2}");
            
        }

    }

}