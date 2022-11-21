using System;

class URI
{

    static void Main(string[] args)
    {
        // Make a program that calculates and shows the volume of a sphere being provided the value of its radius (R)
        // The formula to calculate the volume is: (4/3) * pi * R3. Consider (assign) for pi the value 3.14159

        double π = 3.14159;
        double R = double.Parse(Console.ReadLine());
        double volume = (4.0 / 3) * π * Math.Pow(R, 3);

        // The value must be presented with 3 digits after the decimal point

        Console.WriteLine($"VOLUME = {volume:F3}");
    }
}
