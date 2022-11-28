using System;

class URI {

    static void Main(string[] args) {

        // Read two integer values (A and B)

        string[] values = Console.ReadLine().Split(' ');

        int valueA = int.Parse(values[0]);
        int valueB = int.Parse(values[1]);

        // After, the program should print the message "Sao Multiplos" (are multiples) or "Nao sao Multiplos" (aren’t multiples), corresponding to the read values

        if (valueA % valueB == 0 || valueB % valueA == 0) {
            Console.WriteLine("Sao Multiplos");
        } else {
            Console.WriteLine("Nao sao Multiplos");
        }

    }

}