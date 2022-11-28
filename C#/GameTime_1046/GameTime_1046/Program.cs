using System;

class URI {

    static void Main(string[] args) {

        // Read the start time and end time of a game, in hours

        string[] time = Console.ReadLine().Split(' ');

        decimal startTime = decimal.Parse(time[0]);
        decimal endTime = decimal.Parse(time[1]);
        decimal gameTime = 0;

        // Then calculate the duration of the game, knowing that the game can begin in a day and finish in another day, with a maximum duration of 24 hours

        if (endTime < startTime || endTime == startTime) {
            gameTime = Math.Abs(startTime - (endTime + 24));
        } else {
            gameTime = endTime - startTime;
        }

        // The message must be printed in portuguese “O JOGO DUROU X HORA(S)” that means “THE GAME LASTED X HOUR(S)”

        Console.WriteLine($"O JOGO DUROU {gameTime} HORA(S)");

    }

}