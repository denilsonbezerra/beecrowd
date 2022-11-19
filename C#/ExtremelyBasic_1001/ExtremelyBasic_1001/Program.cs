using System;

class URI
{

    static void Main(string[] args)
    {
        // Read 2 variables, named A and B

        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        // Make the sum of these two variables, assigning its result to the variable X

        int X = A + B;

        // Print X

        Console.WriteLine($"X = {X}");
    }
}