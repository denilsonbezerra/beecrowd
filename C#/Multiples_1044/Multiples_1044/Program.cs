using System;

class URI {

    static void Main(string[] args) {

        string[] values = Console.ReadLine().Split(' ');

        int valueA = int.Parse(values[0]);
        int valueB = int.Parse(values[1]);

        if (valueA % valueB == 0 || valueB % valueA == 0) 
            Console.WriteLine("Sao Multiplos");
        else
            Console.WriteLine("Nao sao Multiplos");

    }

}
