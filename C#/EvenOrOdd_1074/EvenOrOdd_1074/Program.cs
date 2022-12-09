using System;

class URI {

    static void Main(string[] args) {

        int totalNumbers = int.Parse(Console.ReadLine());
        int[] integerNumbers = new int[totalNumbers];

        for (int i = 0; i < integerNumbers.Length; i++) {
            integerNumbers[i] = int.Parse(Console.ReadLine());
        }

        string numberDescription;

        foreach (int number in integerNumbers) {

            if (number % 2 != 0) numberDescription = "ODD ";
            else numberDescription = "EVEN ";

            if (number > 0) numberDescription += "POSITIVE";
            else numberDescription += "NEGATIVE";

            if (number == 0) numberDescription = "NULL";

            Console.WriteLine(numberDescription);

        }

    }

}