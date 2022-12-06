using System;

class URI {

    static void Main(string[] args) {

        float n1 = float.Parse(Console.ReadLine());
        float n2 = float.Parse(Console.ReadLine());
        float n3 = float.Parse(Console.ReadLine());
        float n4 = float.Parse(Console.ReadLine());
        float n5 = float.Parse(Console.ReadLine());
        float n6 = float.Parse(Console.ReadLine());

        float[] numbers = { n1, n2, n3, n4, n5, n6 };
        int i = 0;

        foreach (float number in numbers) {
            if (number > 0) {
                i++;
            }
        }

        Console.WriteLine($"{i} valores positivos");

    }

}