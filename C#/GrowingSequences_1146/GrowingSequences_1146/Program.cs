using System;

class URI {

    static void Main(string[] args) {

        for (;;) {

            int input = int.Parse(Console.ReadLine()); 

            if (input == 0) break;

            for (int i = 1; i <= input; i++) {
                if (i < input) Console.Write($"{i} ");
                else Console.WriteLine(i);
            }

        }

    }

}