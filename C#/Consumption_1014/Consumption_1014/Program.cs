using System;

class URI
{

    static void Main(string[] args)
    {
        // Calculate a car's average consumption being provided the total distance traveled and the spent fuel total
        // The input contains two values: one integer value X representing the total distance (in Km) and the second one is a floating point number Y  representing the spent fuel total (in liters)

        int totalDistance = int.Parse(Console.ReadLine());
        double spentFuel = double.Parse(Console.ReadLine());

        // Present a value that represents the average consumption of a car with 3 digits after the decimal point

        double averageConsumption = totalDistance / spentFuel;

        Console.WriteLine($"{averageConsumption:F3} km/l");
    }
}