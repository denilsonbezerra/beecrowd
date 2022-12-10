using System;

class URI {

    static void Main(string[] args) {

        for (int i = 1, j = 7; i <= 9 && j <= 15; j -= 1) {

            Console.WriteLine($"I={i} J={j}");

            if (j == i + 4) {
                i += 2;
                j += 5;
            }
        }
    }
}