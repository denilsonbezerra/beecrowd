using System;

class URI {

    static void Main(string[] args) {

        // Read 3 double numbers (A, B and C) representing the sides of a triangle

        string[] values = Console.ReadLine().Split(' ');

        // Arrange them in decreasing order so that the side A is the biggest of the three sides

        double[] valuesOrdened = { double.Parse(values[0]), double.Parse(values[1]), double.Parse(values[2]) }; 
        Array.Sort(valuesOrdened); 
        Array.Reverse(valuesOrdened);

        double valueA = valuesOrdened[0];
        double valueB = valuesOrdened[1];
        double valueC = valuesOrdened[2];

        // Next, determine the type of triangle that they can make, based on the following cases always writing an appropriate message:
        // if A ≥ B + C, write the message: NAO FORMA TRIANGULO
        // if A² = B² + C², write the message: TRIANGULO RETANGULO
        // if A² > B² + C², write the message: TRIANGULO OBTUSANGULO
        // if A² < B² + C², write the message: TRIANGULO ACUTANGULO

        if (valueA >= valueB + valueC) {

            Console.WriteLine("NAO FORMA TRIANGULO");

        } else if (Math.Pow(valueA, 2) == Math.Pow(valueB, 2) + Math.Pow(valueC, 2)) {

            Console.WriteLine("TRIANGULO RETANGULO");

        } else if (Math.Pow(valueA, 2) > Math.Pow(valueB, 2) + Math.Pow(valueC, 2)) {

            Console.WriteLine("TRIANGULO OBTUSANGULO");

        } else {
            Console.WriteLine("TRIANGULO ACUTANGULO");
        }

        // if the three sides are the same size, write the message: TRIANGULO EQUILATERO
        // if only two sides are the same and the third one is different, write the message: TRIANGULO ISOSCELES

        if (valueA == valueB && valueB == valueC) {

            Console.WriteLine("TRIANGULO EQUILATERO");

        } else if ((valueA == valueB && valueB != valueC) || (valueB == valueC && valueC != valueA)) {
            Console.WriteLine("TRIANGULO ISOSCELES");
        } 

    }

}
