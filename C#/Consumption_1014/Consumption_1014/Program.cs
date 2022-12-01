using System;

class URI
{

    static void Main(string[] args)
    {
        
        int totalDistance = int.Parse(Console.ReadLine());
        double spentFuel = double.Parse(Console.ReadLine());

        double averageConsumption = totalDistance / spentFuel;

        Console.WriteLine($"{averageConsumption:F3} km/l");
        
    }
    
}
