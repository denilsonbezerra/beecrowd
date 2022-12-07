using System;

class URI {

    static void Main(string[] args) {

        int[] numbers = new int[5];
        numbers[0] = int.Parse(Console.ReadLine());
        numbers[1] = int.Parse(Console.ReadLine());
        numbers[2] = int.Parse(Console.ReadLine());
        numbers[3] = int.Parse(Console.ReadLine());
        numbers[4] = int.Parse(Console.ReadLine());

        int even = 0, odd = 0, positive = 0, negative = 0;

        foreach (int number in numbers) {
            if (number % 2 == 0) {
                even++;
            }
            if (number % 2 != 0) {
                odd++;
            }
            if (number > 0) {
                positive++;
            }
            if (number < 0) {
                negative++;
            }
        }

        Console.WriteLine(
            $"{even} valor(es) par(es)\n" +
            $"{odd} valor(es) impar(es)\n" +
            $"{positive} valor(es) positivo(s)\n" +
            $"{negative} valor(es) negativo(s)"
            );

    }

}