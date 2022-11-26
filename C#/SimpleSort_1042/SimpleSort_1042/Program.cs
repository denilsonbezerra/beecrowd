using System;

class URI {

    static void Main(string[] args) {

        // Read three integers and sort them in ascending order
        // After, print these values in ascending order, a blank line and then the values in the sequence as they were readed

        string[] values = Console.ReadLine().Split(' ');

        int value1 = int.Parse(values[0]);
        int value2 = int.Parse(values[1]);
        int value3 = int.Parse(values[2]);

        if (value1 < value2 && value1 < value3 && value2 < value3) {
            Console.WriteLine(
                $"{value1}\n" +
                $"{value2}\n" +
                $"{value3}\n"
                );
        } else if (value1 < value2 && value1 < value3 && value3 < value2) {
            Console.WriteLine(
                $"{value1}\n" +
                $"{value3}\n" +
                $"{value2}\n"
                );
        } else if (value2 < value1 && value2 < value3 && value1 < value3) {
            Console.WriteLine(
                $"{value2}\n" +
                $"{value1}\n" +
                $"{value3}\n"
                );
        } else if (value2 < value1 && value2 < value3 && value3 < value1) {
            Console.WriteLine(
                $"{value2}\n" +
                $"{value3}\n" +
                $"{value1}\n"
                );
        } else if (value3 < value1 && value3 < value2 && value1 < value2) {
            Console.WriteLine(
                $"{value3}\n" +
                $"{value1}\n" +
                $"{value2}\n"
                );
        } else {
            Console.WriteLine(
                $"{value3}\n" +
                $"{value2}\n" +
                $"{value1}\n"
                );
        }

        Console.WriteLine(
            $"{value1}\n" +
            $"{value2}\n" +
            $"{value3}"
            );

    }

}