using System;

class URI
{
    
    static void Main(string[] args)
    {

        int hours = int.Parse(Console.ReadLine());
        int averageSpeed = int.Parse(Console.ReadLine());

        double distance = averageSpeed * hours;
        double spentFuel = distance / 12;

        Console.WriteLine($"{spentFuel:F3}");
        
    }
    
}
