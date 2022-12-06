using System;

class URI {

    static void Main(string[] args) {

        int[] numbers = new int[5];
        numbers[0] = int.Parse(Console.ReadLine());
        numbers[1] = int.Parse(Console.ReadLine());
        numbers[2] = int.Parse(Console.ReadLine());
        numbers[3] = int.Parse(Console.ReadLine());
        numbers[4] = int.Parse(Console.ReadLine());

        int i = 0;

        foreach (int number in numbers) {
            if (number % 2 == 0) {
                i++;
            }
        }

        Console.WriteLine($"{i} valores pares");

    }

}