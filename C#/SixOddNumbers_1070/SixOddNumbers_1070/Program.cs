using System;

class URI {

    static void Main(string[] args) {

        int input = int.Parse(Console.ReadLine());

        for (int i = input; i < input + 12; i += 2) {
            if (i == input && input % 2 == 0) {
                i++;
            }
            Console.WriteLine(i);
        }

    }

}