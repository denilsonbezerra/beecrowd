using System;

class URI {

    static void Main(string[] args) {

        string[] input;

        do {

            input = Console.ReadLine().Split();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);

            if (x == y) break;
            else if (x < y) Console.WriteLine("Crescente");
            else Console.WriteLine("Decrescente");

        } while (true);

    }

}