using System;

class URI
{

    static void Main(string[] args)
    {
        // Read four integer values named A, B, C and D

        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());

        // Calculate and print the difference of product A and B by the product of C and D

        Console.WriteLine($"DIFERENCA = {A * B - C * D}");
    }
}