using System;

class URI {

    static void Main(string[] args) {

        float[] numbers = new float[6];
        numbers[0] = float.Parse(Console.ReadLine());
        numbers[1] = float.Parse(Console.ReadLine());
        numbers[2] = float.Parse(Console.ReadLine());
        numbers[3] = float.Parse(Console.ReadLine());
        numbers[4] = float.Parse(Console.ReadLine());
        numbers[5] = float.Parse(Console.ReadLine());

        int i = 0;
        float media = 0;

        foreach (float number in numbers) {
            if (number > 0) {
                i++;
                media += number;
            }
        }

        media /= i;

        Console.WriteLine(
            $"{i} valores positivos\n" +
            $"{media:F1}"
            );

    }

}
