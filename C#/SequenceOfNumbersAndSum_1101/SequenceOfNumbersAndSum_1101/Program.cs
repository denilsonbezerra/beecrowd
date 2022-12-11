using System;

class URI {

    static void Main(string[] args) {

        string[] input;

        do {

            input = Console.ReadLine().Split();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            int soma = 0;

            if (x <= 0 || y <= 0) break;

            if (x < y) {

                for (int i = x; i <= y; i++) {
                    soma += i;
                    Console.Write($"{i} ");
                }

            } else {

                for (int i = y; i <= x; i++) {
                    soma += i;
                    Console.Write($"{i} ");
                }

            }

            Console.WriteLine($"Sum={soma}");
            soma = 0;

        } while (true);
    }
}