using System;

class URI
{

    static void Main(string[] args)
    {
        // Read input 2 integer numbers

        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        // Calculate the sum between them

        int SOMA = A + B;

        // Write the value of sum of A and B

        Console.WriteLine($"SOMA = {SOMA}");
    }
}