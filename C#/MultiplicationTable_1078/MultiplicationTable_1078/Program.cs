using System;

class URI {

    static void Main(string[] args) {

        int input = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++) {
            Console.WriteLine($"{i} x {input} = {i * input}");
        }

    }

}