using System;

class URI {

    static void Main(string[] args) {

        int[] numbers = new int[100];
        int highestValue = numbers[0], highestPosition = 0;

        for (int i = 0; i < numbers.Length ; i++) {

            numbers[i] = int.Parse(Console.ReadLine());

            if (numbers[i] > highestValue) {
                highestValue = numbers[i];
                highestPosition = i + 1;
            }

        }

        Console.WriteLine($"{highestValue}\n{highestPosition}");

    }

}