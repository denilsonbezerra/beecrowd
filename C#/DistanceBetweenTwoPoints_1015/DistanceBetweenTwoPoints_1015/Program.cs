using System;

class URI
{

    static void Main(string[] args)
    {

        string[] values1 = Console.ReadLine().Split();
        double x1 = double.Parse(values1[0]);
        double y1 = double.Parse(values1[1]);

        string[] values2 = Console.ReadLine().Split();
        double x2 = double.Parse(values2[0]);
        double y2 = double.Parse(values2[1]);

        double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

        Console.WriteLine($"{distance:F4}");

    }

}
