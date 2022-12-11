using System;

class URI {

    static void Main(string[] args) {

        int quantityOfPairs = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantityOfPairs; i++) {

            string[] input = Console.ReadLine().Split();
            double x = double.Parse(input[0]);
            double y = double.Parse(input[1]);

            if (y != 0) Console.WriteLine($"{x / y:F1}");
            else Console.WriteLine("divisao impossivel");

        }
    }
}