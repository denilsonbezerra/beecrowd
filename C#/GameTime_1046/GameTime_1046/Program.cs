using System;

class URI {

    static void Main(string[] args) {

        string[] time = Console.ReadLine().Split(' ');

        decimal startTime = decimal.Parse(time[0]);
        decimal endTime = decimal.Parse(time[1]);
        decimal gameTime = 0;

        if (endTime < startTime || endTime == startTime) {
            gameTime = Math.Abs(startTime - (endTime + 24));
        } else {
            gameTime = endTime - startTime;
        }

        Console.WriteLine($"O JOGO DUROU {gameTime} HORA(S)");

    }

}
