using System;

class URI
{

    static void Main(string[] args)
    {
        // Formula to calculate the area of a circumference is defined as A = π . R2 | Considering to this problem that π = 3.14159
        // The input contains a value of floating point (double precision), that is the variable R

        double π = 3.14159;
        double R = double.Parse(Console.ReadLine());
        double A = Math.Pow(R, 2) * π;

        // Present the message "A=" with four places after the decimal point

        Console.WriteLine($"A={A:F4}");
    }
}