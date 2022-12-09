using System;

class URI {

    static void Main(string[] args) {

        int numberOfTests = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfTests; i++) {

            string[] tests = Console.ReadLine().Split(' ');
            float n1 = float.Parse(tests[0]);
            float n2 = float.Parse(tests[1]);
            float n3 = float.Parse(tests[2]);

            float average = (n1 * 2 + n2 * 3 + n3 * 5) / 10;
            Console.WriteLine($"{average:F1}");

        }

    }

}