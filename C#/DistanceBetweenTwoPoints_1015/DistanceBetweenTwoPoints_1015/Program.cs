using System;

class URI
{

    static void Main(string[] args)
    {
        // Read the four values corresponding to the x and y axes of two points in the plane, p1 (x1, y1) and p2 (x2, y2) and calculate the distance between them, showing four decimal places after the comma, according to the formula
        // Distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2))
        // The input contains two lines of data:
        // The first one contains two double values: x1 y1

        string[] firstValues = Console.ReadLine().Split();
        double x1 = double.Parse(firstValues[0]);
        double y1 = double.Parse(firstValues[1]);

        // and the second one also contains two double values: x2 y2

        string[] secondValues = Console.ReadLine().Split();
        double x2 = double.Parse(secondValues[0]);
        double y2 = double.Parse(secondValues[1]);

        double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

        Console.WriteLine($"{distance:F4}");
    }
}