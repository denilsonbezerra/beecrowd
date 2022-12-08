using System;

class URI {

    static void Main(string[] args) {

        int totalNumbers = int.Parse(Console.ReadLine());
        int[] integerNumbers = new int[totalNumbers];

        for (int i = 0; i < integerNumbers.Length; i++) {
            integerNumbers[i] = int.Parse(Console.ReadLine());
        }

        int numbersIn = 0;
        int numbersOut = 0;

        foreach (int number in integerNumbers) {
            if (number >= 10 && number <= 20) numbersIn++;
            else numbersOut++;
        }

        Console.WriteLine(
            $"{numbersIn} in\n" +
            $"{numbersOut} out");

    }

}