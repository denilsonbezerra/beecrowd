using System;

class URI
{

    static void Main(string[] args)
    {
        // Read two integer values | Calculate the product between them and store the result in a variable

        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        int PROD = A * B;

        // Print the PROD

        Console.WriteLine($"PROD = {PROD}");
    }
}