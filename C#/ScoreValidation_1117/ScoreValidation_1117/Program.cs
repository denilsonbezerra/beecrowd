using System;

class URI {

    static void Main(string[] args) {

        double average = 0;

        for (int i = 0; i < 2; i++) {
            
            double input = double.Parse(Console.ReadLine());

            if (input < 0 || input > 10) {
                Console.WriteLine("nota invalida");
                i--;
            } else average += input;

        }

        Console.WriteLine($"media = {average / 2:F2}");

    }

}