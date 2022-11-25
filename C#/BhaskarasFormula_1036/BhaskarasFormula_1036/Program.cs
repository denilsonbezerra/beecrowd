using System;

class URI {

    static void Main(string[] args) {

        // Read 3 floating-point numbers
        // After, print the roots of bhaskara’s formula: (-B +- √(B * B - 4 * A * C)) / (2 * A)
        // If it's impossible to calculate the roots because a division by zero or a square root of a negative number, presents the message “Impossivel calcular”

        string[] numbers = Console.ReadLine().Split();

        double A = double.Parse(numbers[0]);
        double B = double.Parse(numbers[1]);
        double C = double.Parse(numbers[2]);

        double delta = Math.Pow(B, 2) - 4 * A * C;
        double rootDelta = Math.Sqrt(delta);

        if (delta < 0 || A == 0) {
            Console.WriteLine("Impossivel calcular");
        } else {

            double root1 = (-B + rootDelta) / (2 * A);
            double root2 = (-B - rootDelta) / (2 * A);

            Console.WriteLine(
                $"R1 = {root1:F5}\n" +
                $"R2 = {root2:F5}"
                );
                
        }

    }

}