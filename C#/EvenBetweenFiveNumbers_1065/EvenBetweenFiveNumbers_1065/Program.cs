using System;

class URI {

    static void Main(string[] args) {

        int even = 0;

        for (int i = 0; i < 5; i++) {

            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0) {
                even++;
            }
        }

        Console.WriteLine($"{even} valores pares");

    }

}
