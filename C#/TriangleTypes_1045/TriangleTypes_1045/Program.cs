using System;

class URI {

    static void Main(string[] args) {

        string[] values = Console.ReadLine().Split(' ');

        double[] valuesOrdened = { double.Parse(values[0]), double.Parse(values[1]), double.Parse(values[2]) }; 
        Array.Sort(valuesOrdened); 
        Array.Reverse(valuesOrdened);

        double valueA = valuesOrdened[0];
        double valueB = valuesOrdened[1];
        double valueC = valuesOrdened[2];

        if (valueA >= valueB + valueC)
            Console.WriteLine("NAO FORMA TRIANGULO");
        else if (Math.Pow(valueA, 2) == Math.Pow(valueB, 2) + Math.Pow(valueC, 2))
            Console.WriteLine("TRIANGULO RETANGULO");
        else if (Math.Pow(valueA, 2) > Math.Pow(valueB, 2) + Math.Pow(valueC, 2))
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        else
            Console.WriteLine("TRIANGULO ACUTANGULO");

        if (valueA == valueB && valueB == valueC)
            Console.WriteLine("TRIANGULO EQUILATERO");
        else if ((valueA == valueB && valueB != valueC) || (valueB == valueC && valueC != valueA))
            Console.WriteLine("TRIANGULO ISOSCELES");

    }

}
