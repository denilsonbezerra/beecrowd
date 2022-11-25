using System;

class URI
{

    static void Main(string[] args)
    {

        // Read 4 integer values A, B, C and D

        string[] readValue = Console.ReadLine().Split();

        int valueA = int.Parse(readValue[0]);
        int valueB = int.Parse(readValue[1]);
        int valueC = int.Parse(readValue[2]);
        int valueD = int.Parse(readValue[3]);

        // Then if B is greater than C and D is greater than A and if the sum of C and D is greater than the sum of A and B and if C and D were positives values and if A is even, write the message “Valores aceitos” (Accepted values).
        // Otherwise, write the message “Valores nao aceitos” (Values not accepted).

        if (valueB > valueC && valueD > valueA && valueC + valueD > valueA + valueB && valueC > 0 && valueD > 0 && valueA % 2 == 0) {
            Console.WriteLine("Valores aceitos");
        } else {
            Console.WriteLine("Valores nao aceitos");
        }

    }

}