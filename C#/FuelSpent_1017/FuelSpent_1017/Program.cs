using System;

class URI
{
    static void Main(string[] args)
    {
        // Little John wants to calculate and show the amount of spent fuel liters on a trip, using a car that does 12 Km/L
        // The input contains two integers
        // To perform the calculation, have to read spent time (in hours) and the same average speed (km/h)

        int hours = int.Parse(Console.ReadLine());
        int averageSpeed = int.Parse(Console.ReadLine());

        // Get distance, then calculate how many liters would be needed

        double distance = averageSpeed * hours;
        double spentFuel = distance / 12;

        // Show the value with three decimal places after the point

        Console.WriteLine($"{spentFuel:F3}");
    }
}