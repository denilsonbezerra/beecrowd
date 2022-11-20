using System;

class URI
{

    static void Main(string[] args)
    {
        // Read two floating points' values of double precision A and B, corresponding to two student's grades

        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());

        // Calculate the student's average, considering that grade A has weight 3.5 and B has weight 7.5

        double MEDIA = (A * 3.5 + B * 7.5) / 11.0;

        // Print MEDIA with 5 digits after the decimal point

        Console.WriteLine($"MEDIA = {MEDIA:F5}");
    }
}