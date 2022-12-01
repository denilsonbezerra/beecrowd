using System;

class URI
{

    static void Main(string[] args)
    {

        string[] values = Console.ReadLine().Split(' ');
        double A = double.Parse(values[0]);
        double B = double.Parse(values[1]);
        double C = double.Parse(values[2]);

        double areaTriangle = (A * C) / 2;

        double areaCircle = 3.14159 * Math.Pow(C, 2);

        double areaTrapezium = (A + B) * C / 2;

        double areaSquare = Math.Pow(B, 2);

        double areaRectangle = A * B;

        Console.WriteLine(
            $"TRIANGULO: {areaTriangle:F3}\n" +
            $"CIRCULO: {areaCircle:F3}\n" +
            $"TRAPEZIO: {areaTrapezium:F3}\n" +
            $"QUADRADO: {areaSquare:F3}\n" +
            $"RETANGULO: {areaRectangle:F3}"
            );
        
    }
    
}
