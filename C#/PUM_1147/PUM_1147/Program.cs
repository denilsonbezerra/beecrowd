using System;

class URI {

    static void Main(string[] args) {

        int input = int.Parse(Console.ReadLine());

        for (int i = 1, j = 1; i <= input; i ++, j+= 4) {
            Console.WriteLine($"{j} {j + 1} {j + 2} PUM");
        }

    }

}