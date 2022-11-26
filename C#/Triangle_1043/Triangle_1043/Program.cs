using System;

class URI {

    static void Main(string[] args) {

        // Read three point floating values (A, B and C) and verify if is possible to make a triangle with them
        // If it is possible, calculate the perimeter of the triangle and print the message: Perimetro = XX.X
        // If it is not possible, calculate the area of the trapezium which basis A and B and C as height, and print the message: Area = XX.X

        string[] values = Console.ReadLine().Split(' ');

        float valueA = float.Parse(values[0]);
        float valueB = float.Parse(values[1]);
        float valueC = float.Parse(values[2]);

        if ((valueA > Math.Abs(valueB - valueC) && valueA < valueB + valueC) || (valueB > Math.Abs(valueA - valueC) && valueB < valueA + valueC) || (valueC > Math.Abs(valueA - valueB) && valueC < valueA + valueB)) {

            float perimeterOfTriangle = valueA + valueB + valueC;
            Console.WriteLine($"Perimetro = {perimeterOfTriangle:F1}");

        } else {

            float areaOfTrapezium = ((valueA + valueB) * valueC) / 2;
            Console.WriteLine($"Area = {areaOfTrapezium:F1}");

        }

    }

}