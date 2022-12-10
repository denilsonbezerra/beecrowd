using System;

class URI {

    static void Main(string[] args) {

        int testCases = int.Parse(Console.ReadLine());
        int total, amountRabbit = 0, amountRat = 0, amountFrog = 0;

        for (int i = 0; i < testCases; i++) {

            string[] input = Console.ReadLine().Split();

            switch (input[1]) {
                case "C": amountRabbit += int.Parse(input[0]); break;
                case "R": amountRat += int.Parse(input[0]); break;
                case "S": amountFrog += int.Parse(input[0]); break;
            }

        }

        total = amountRabbit + amountRat + amountFrog;
        double percentualRabbit = amountRabbit * 100.0 / total;
        double percentualRat = amountRat * 100.0 / total;
        double percentualFrog = amountFrog * 100.0 / total;

        Console.WriteLine(
            $"Total: {total} cobaias\n" +
            $"Total de coelhos: {amountRabbit}\n" +
            $"Total de ratos: {amountRat}\n" +
            $"Total de sapos: {amountFrog}\n" +
            $"Percentual de coelhos: {percentualRabbit:F2} %\n" +
            $"Percentual de ratos: {percentualRat:F2} %\n" +
            $"Percentual de sapos: {percentualFrog:F2} %");

    }

}