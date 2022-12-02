using System;

class URI {

    static void Main(string[] args) {

        string[] studentScores = Console.ReadLine().Split(' ');

        double number1 = double.Parse(studentScores[0]);
        double number2 = double.Parse(studentScores[1]);
        double number3 = double.Parse(studentScores[2]);
        double number4 = double.Parse(studentScores[3]);

        double average = Math.Round((number1 * 2 + number2 * 3 + number3 * 4 + number4) / 10, 1, MidpointRounding.ToEven);

        Console.WriteLine($"Media: {average}");

        if (average >= 7) {
            Console.WriteLine("Aluno aprovado.");
        } else if (average < 5) {
            Console.WriteLine("Aluno reprovado.");
        } else {

            Console.WriteLine("Aluno em exame.");

            double examScore = double.Parse(Console.ReadLine());

            Console.WriteLine($"Nota do exame: {examScore:F1}");

            double finalAverage = Math.Round((average + examScore) / 2, 1, MidpointRounding.ToEven);

            if (finalAverage >= 5) {
                Console.WriteLine("Aluno aprovado.");
            } else {
                Console.WriteLine("Aluno reprovado.");
            }

            Console.WriteLine($"Media final: {finalAverage}");

        }

    }

}
