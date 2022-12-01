using System;

class URI {

    static void Main(string[] args) {

        string[] studentScores = Console.ReadLine().Split(' ');

        decimal number1 = decimal.Parse(studentScores[0]);
        decimal number2 = decimal.Parse(studentScores[1]);
        decimal number3 = decimal.Parse(studentScores[2]);
        decimal number4 = decimal.Parse(studentScores[3]);

        decimal average = Math.Round((number1 * 2 + number2 * 3 + number3 * 4 + number4) / 10, 1, MidpointRounding.ToEven);

        Console.WriteLine($"Media: {average}");

        if (average >= 7) {
            Console.WriteLine("Aluno aprovado.");
        } else if (average < 5) {
            Console.WriteLine("Aluno reprovado.");
        } else {

            Console.WriteLine("Aluno em exame.");

            decimal examScore = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Nota do exame: {examScore:F1}");

            decimal finalAverage = Math.Round((average + examScore) / 2, 1, MidpointRounding.ToEven);

            if (finalAverage >= 5) {
                Console.WriteLine("Aluno aprovado.");
            } else {
                Console.WriteLine("Aluno reprovado.");
            }

            Console.WriteLine($"Media final: {finalAverage}");

        }

    }

}
