using System;

class URI {

    static void Main(string[] args) {

        int start = int.Parse(Console.ReadLine()), final = int.Parse(Console.ReadLine());

        if (start > final) {
            int aux = final;
            final = start;
            start = aux;
        }

        for (int i = start + 1; i < final; i++) {
            if (i % 5 == 2 || i % 5 == 3) Console.WriteLine(i);
        }

    }
}