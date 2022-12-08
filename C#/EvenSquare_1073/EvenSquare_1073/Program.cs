using System;

class URI {

    static void Main(string[] args) {

        int input = int.Parse(Console.ReadLine());

        for (int i = 2; i <= input; i += 2) {
            Console.WriteLine($"{i}^2 = {i * i}");
        }

    }

}