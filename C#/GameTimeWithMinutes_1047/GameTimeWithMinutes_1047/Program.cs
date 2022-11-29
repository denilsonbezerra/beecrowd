using System;

class URI {

    static void Main(string[] args) {

        // Read the start time and end time of a game, in hours and minutes (initial hour, initial minute, final hour, final minute). Then print the duration of the game, knowing that the game can begin in a day and finish in another day,

        // Obs.: With a maximum game time of 24 hours and the minimum game time of 1 minute.

        string[] time = Console.ReadLine().Split(' ');

        decimal startTimeHour = decimal.Parse(time[0]);
        decimal startTimeMinutes = decimal.Parse(time[1]);

        decimal endTimeHour = decimal.Parse(time[2]);
        decimal endTimeMinutes = decimal.Parse(time[3]);

        decimal gameHours = 0;
        decimal gameMinutes = 0;

        if (endTimeHour == startTimeHour && endTimeMinutes > startTimeMinutes) {
            gameHours = 0;
        } else if (endTimeHour < startTimeHour || endTimeHour == startTimeHour) {
            gameHours = Math.Abs(startTimeHour - (endTimeHour + 24));
        } else {
            gameHours = endTimeHour - startTimeHour;
        }

        if (endTimeMinutes < startTimeMinutes) {
            gameMinutes = Math.Abs(startTimeMinutes - (endTimeMinutes + 60));
            gameHours--;
        } else {
            gameMinutes = endTimeMinutes - startTimeMinutes;
        }

        Console.WriteLine($"O JOGO DUROU {gameHours} HORA(S) E {gameMinutes} MINUTO(S)");

    }

}