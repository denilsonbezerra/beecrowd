using System;

class URI {

    static void Main(string[] args) {

        int input = int.Parse(Console.ReadLine());

        for (int i = 1; i <= input; i++) {

            Console.WriteLine(
                $"{i} {i * i} {i * i * i}\n" +
                $"{i} {i * i + 1} {i * i * i + 1}");

        }

    }

}