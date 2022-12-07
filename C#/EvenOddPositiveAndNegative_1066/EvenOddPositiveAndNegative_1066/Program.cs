using System;

class URI {

    static void Main(string[] args) {

        int inputNumber, even = 0, odd = 0, positive = 0, negative = 0;

        for (int i = 0; i < 5; i++) {

            inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber % 2 == 0) even++;
            else odd++;
            
            if (inputNumber > 0) positive++;
            else if (inputNumber < 0) negative++;

        }

        Console.WriteLine(
            $"{even} valor(es) par(es)\n" +
            $"{odd} valor(es) impar(es)\n" +
            $"{positive} valor(es) positivo(s)\n" +
            $"{negative} valor(es) negativo(s)");

    }

}
