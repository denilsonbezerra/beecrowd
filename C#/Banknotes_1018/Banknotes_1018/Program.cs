using System;

class URI
{
    static void Main(string[] args)
    {
        // Read an integer value and calculate the smallest possible number of banknotes in which the value may be decomposed
        // The input contains an integer value N (0 < N < 1000000)
        // The possible banknotes are 100, 50, 20, 10, 5, 2 e 1

        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(number);

        int[] banknotes = { 100, 50, 20, 10, 5, 2, 1 };

        foreach (int banknote in banknotes)
        {

            int banknoteNum = number / banknote;
            number -= banknote * banknoteNum;

            Console.WriteLine($"{banknoteNum} nota(s) de R$ {banknote},00");
        }
    }
}