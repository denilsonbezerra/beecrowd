using System;

class URI
{

    static void Main(string[] args)
    {

        string[] values = Console.ReadLine().Split(' ');

        int A = int.Parse(values[0]);
        int B = int.Parse(values[1]);
        int C = int.Parse(values[2]);

        int greatestAB = (A + B + Math.Abs(A - B)) / 2;
        int greatest = (greatestAB + C + Math.Abs(greatestAB - C)) / 2;

        Console.WriteLine($"{greatest} eh o maior");
        
    }
    
}
