using System;

class URI
{

    static void Main(string[] args)
    {

        double π = 3.14159;
        double R = double.Parse(Console.ReadLine());
        double A = Math.Pow(R, 2) * π;

        Console.WriteLine($"A={A:F4}");
        
    }
    
}
