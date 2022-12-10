using System;

class URI {

    static void Main(string[] args) {

        int testCases = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCases; i++) {

            string[] input = Console.ReadLine().Split();

            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            int soma = 0;

            if (x < y) {
                for (int j = x + 1; j < y; j++)
                    if (j % 2 != 0) soma += j;
            } else {
                for (int j = y + 1; j < x; j++)
                    if (j % 2 != 0) soma += j;
            }

            Console.WriteLine(soma);

        }

    }

}