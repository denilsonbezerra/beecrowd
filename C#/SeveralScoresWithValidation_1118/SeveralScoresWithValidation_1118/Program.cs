using System;

class URI {

    static void Main(string[] args) {

        double average = 0;

        for (int i = 0; i <= 2; i++) {

            double input = double.Parse(Console.ReadLine());

            if (input < 0 || input > 10) {
                Console.WriteLine("nota invalida");
                i--;
            } else average += input;

            if (i == 1) {

                Console.WriteLine($"media = {average / 2:F2}");
                average = 0;

                int newCalculate = 0;

                do {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    newCalculate = int.Parse(Console.ReadLine());
                } while (newCalculate < 1 || newCalculate > 2);

                if (newCalculate == 1) i -= 2;
                else break;
            }
        }
    }
}