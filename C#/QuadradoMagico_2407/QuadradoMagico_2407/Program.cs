using System;
using System.Linq;
using System.Collections.Generic;

class URI {

    static void Main(string[] args) {

        int nLine = int.Parse(Console.ReadLine()), nColum = nLine;
        int[,] magicSquare = new int[nLine, nColum];

        int sumOfLine = 0, sumOfColum = 0, sumOfDiagonal = 0, result = 0;
        var hashSet = new HashSet<int>();
        bool validMagicSquare = true;

        for (int i = 0; i < nLine; i++) {

            string[] input = Console.ReadLine().Split();

            sumOfColum += int.Parse(input[0]);
            sumOfDiagonal += int.Parse(input[i]);

            for (int j = 0; j < nColum; j++) {

                magicSquare[i, j] = int.Parse(input[j]);
                hashSet.Add(int.Parse(input[j]));

                if (j == 0) sumOfLine += int.Parse(input[j]);

                if (int.Parse(input[j]) > nLine * nLine) validMagicSquare = false;

            }

        }

        if (validMagicSquare && hashSet.Count() == nLine * nLine && sumOfLine == sumOfColum && sumOfColum == sumOfDiagonal) result = sumOfLine;

        Console.WriteLine(result);

    }

}