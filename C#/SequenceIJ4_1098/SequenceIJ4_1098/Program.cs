using System;

class URI {

    static void Main(string[] args) {

        for (double i = 0, j = 1; i <= 2; j++) {

            Console.WriteLine($"I={i} J={j}");

            if (j == i + 3) {
                i = Math.Round(i + 0.2, 1);
                j = Math.Round(j - 2.8, 1);
            }
        }
    }
}