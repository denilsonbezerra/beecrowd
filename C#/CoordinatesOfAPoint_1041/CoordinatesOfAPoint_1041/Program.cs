using System;

class URI {

    static void Main(string[] args) {

        string[] coordinates = Console.ReadLine().Split(' ');

        float x = float.Parse(coordinates[0]);
        float y = float.Parse(coordinates[1]);

        if (x != 0 && y == 0)
            Console.WriteLine("Eixo X");
        else if (x == 0 && y != 0)
            Console.WriteLine("Eixo Y");
        else if (x > 0 && y > 0)
            Console.WriteLine("Q1");
        else if (x < 0 && y > 0)
            Console.WriteLine("Q2");
        else if (x < 0 && x < 0)
            Console.WriteLine("Q3");
        else if (x > 0 && y < 0)
            Console.WriteLine("Q4");
        else
            Console.WriteLine("Origem");

    }

}
