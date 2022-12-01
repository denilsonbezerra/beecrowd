using System;

class URI
{

    static void Main(string[] args)
    {

        double π = 3.14159;
        double R = double.Parse(Console.ReadLine());
        double volume = (4.0 / 3) * π * Math.Pow(R, 3);

        Console.WriteLine($"VOLUME = {volume:F3}");
        
    }
    
}
