using System;

class URI {

    static void Main(string[] args) {

        for (int i = 1, j = 7; i <= 9 && j >= 5; j -= 1) {

            Console.WriteLine($"I={i} J={j}");

            if (j == 5) {
                i += 2;
                j += 3;
            }
        }
    }
}