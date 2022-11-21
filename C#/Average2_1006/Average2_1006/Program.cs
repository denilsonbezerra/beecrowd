using System;

class URI
{

    static void Main(string[] args)
    {
        // Read three values (variables A, B and C)

        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());

        // Calculate the average, considering that grade A has weight 2, grade B has weight 3 and the grade C has weight 5

        double media = (A * 2 + B * 3 + C * 5) / 10;

        // Print MEDIA

        Console.WriteLine($"MEDIA = {media:F1}");
    }
}
