using System;

class URI {

    static void Main(string[] args) {

        // Read four numbers (N1, N2, N3, N4), which one with 1 digit after the decimal point, corresponding to 4 scores obtained by a student

        string[] studentScores = Console.ReadLine().Split(' ');

        // Calculate the average with weights 2, 3, 4 e 1 respectively, for these 4 scores and print the message "Media: " (Average), followed by the calculated result

        decimal number1 = decimal.Parse(studentScores[0]);
        decimal number2 = decimal.Parse(studentScores[1]);
        decimal number3 = decimal.Parse(studentScores[2]);
        decimal number4 = decimal.Parse(studentScores[3]);

        decimal average = Math.Round((number1 * 2 + number2 * 3 + number3 * 4 + number4) / 10, 1, MidpointRounding.ToEven);

        Console.WriteLine($"Media: {average}");

        // If the average was 7.0 or more, print the message "Aluno aprovado." (Approved Student)

        if (average >= 7) {
            Console.WriteLine("Aluno aprovado.");
        }

        // If the average was less than 5.0, print the message: "Aluno reprovado." (Reproved Student)

        else if (average < 5) {
            Console.WriteLine("Aluno reprovado.");
        }

        // If the average was between 5.0 and 6.9, including these, the program must print the message "Aluno em exame." (In exam student)

        else {

            Console.WriteLine("Aluno em exame.");

            // In case of exam, read one more score. Print the message "Nota do exame: " (Exam score) followed by the typed score

            decimal examScore = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Nota do exame: {examScore:F1}");

            // Recalculate the average (sum the exam score with the previous calculated average and divide by 2)

            decimal finalAverage = Math.Round((average + examScore) / 2, 1, MidpointRounding.ToEven);

            // Print the message “Aluno aprovado.” (Approved student) in case of average 5.0 or more)

            if (finalAverage >= 5) {
                Console.WriteLine("Aluno aprovado.");
            }

            // or "Aluno reprovado." (Reproved student) in case of average 4.9 or less

            else {
                Console.WriteLine("Aluno reprovado.");
            }

            // For these 2 cases (approved or reproved after the exam) print the message "Media final: " (Final average) followed by the final average for this student in the last line

            Console.WriteLine($"Media final: {finalAverage}");

        }

    }

}