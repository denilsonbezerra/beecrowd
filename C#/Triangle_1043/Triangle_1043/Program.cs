using System;

class URI {

    static void Main(string[] args) {

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
