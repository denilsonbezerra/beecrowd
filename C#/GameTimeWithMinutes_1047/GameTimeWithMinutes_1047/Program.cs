using System;

class URI {

    static void Main(string[] args) {

        string[] time = Console.ReadLine().Split(' ');

        int startTimeHour = int.Parse(time[0]);
        int startTimeMinutes = int.Parse(time[1]);

        int endTimeHour = int.Parse(time[2]);
        int endTimeMinutes = int.Parse(time[3]);

        int gameHours, gameMinutes;

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
