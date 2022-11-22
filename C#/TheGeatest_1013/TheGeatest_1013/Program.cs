using System;

class URI
{

    static void Main(string[] args)
    {
        // Make a program that reads 3 integer values and present the greatest one followed by the message "eh o maior"
        // Use the following formula: MaiorAB = (a + b + abs(a - b)) / 2

        string[] values = Console.ReadLine().Split(' ');

        int A = int.Parse(values[0]);
        int B = int.Parse(values[1]);
        int C = int.Parse(values[2]);

        int greatestAB = (A + B + Math.Abs(A - B)) / 2;
        int greatest = (greatestAB + C + Math.Abs(greatestAB - C)) / 2;

        // Other solution is: int greatest = values.Select(int.Parse).Max();

        Console.WriteLine($"{greatest} eh o maior");
    }
}