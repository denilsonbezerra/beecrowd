using System;

class URI
{

    static void Main(string[] args)
    {

        string[] readValue = Console.ReadLine().Split();

        int valueA = int.Parse(readValue[0]);
        int valueB = int.Parse(readValue[1]);
        int valueC = int.Parse(readValue[2]);
        int valueD = int.Parse(readValue[3]);

        if (valueB > valueC && valueD > valueA && valueC + valueD > valueA + valueB && valueC > 0 && valueD > 0 && valueA % 2 == 0) {
            Console.WriteLine("Valores aceitos");
        } else {
            Console.WriteLine("Valores nao aceitos");
        }

    }

}
