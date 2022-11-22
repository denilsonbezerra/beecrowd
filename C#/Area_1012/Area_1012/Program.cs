using System;

class URI
{

    static void Main(string[] args)
    {
        // Make a program that reads three floating point values: A, B and C

        string[] values = Console.ReadLine().Split(' ');
        double A = double.Parse(values[0]);
        double B = double.Parse(values[1]);
        double C = double.Parse(values[2]);

        // Then, calculate:
        // a) the area of the rectangled triangle ((base * height) / 2) that has base A and height C

        double areaTriangle = (A * C) / 2;

        // b) the area of the radius's circle C (π × radius²) (π = 3.14159)

        double areaCircle = 3.14159 * Math.Pow(C, 2);

        // c) the area of the trapezium ((A + B) * C / 2) which has A and B by base, and C by height

        double areaTrapezium = (A + B) * C / 2;

        // d) the area of ​​the square (B²) that has side B 

        double areaSquare = Math.Pow(B, 2);

        // e) the area of the rectangle (A * B) that has sides A and B

        double areaRectangle = A * B;

        // Show results line by line

        Console.WriteLine(
            $"TRIANGULO: {areaTriangle:F3}\n" +
            $"CIRCULO: {areaCircle:F3}\n" +
            $"TRAPEZIO: {areaTrapezium:F3}\n" +
            $"QUADRADO: {areaSquare:F3}\n" +
            $"RETANGULO: {areaRectangle:F3}"
            );
    }
}