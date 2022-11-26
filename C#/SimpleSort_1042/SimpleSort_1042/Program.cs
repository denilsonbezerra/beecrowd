using System;

class URI {

    static void Main(string[] args) {

        // Read three integers and sort them in ascending order
        // After, print these values in ascending order, a blank line and then the values in the sequence as they were readed

        string[] values = Console.ReadLine().Split(' ');

        int[] valuesInt = { int.Parse(values[0]), int.Parse(values[1]), int.Parse(values[2]) };

        int[] valuesSort = { int.Parse(values[0]), int.Parse(values[1]), int.Parse(values[2]) };
        Array.Sort(valuesSort);

        Console.WriteLine(
            $"{valuesSort[0]}\n" +
            $"{valuesSort[1]}\n" +
            $"{valuesSort[2]}\n"
            );

        Console.WriteLine(
            $"{valuesInt[0]}\n" +
            $"{valuesInt[1]}\n" +
            $"{valuesInt[2]}"
            );

    }

}
