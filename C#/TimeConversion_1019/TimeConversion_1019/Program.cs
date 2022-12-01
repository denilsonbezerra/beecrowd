using System;

class URI
{

    static void Main(string[] args)
    {

        int seconds = int.Parse(Console.ReadLine());

        int hours = 0;
        int minutes = 0;

        for (hours = 0; seconds >= 3600; hours++)
        {
            seconds -= 3600;
        }

        for (minutes = 0; seconds >= 60; minutes++)
        {
            seconds -= 60;
        }

        Console.WriteLine($"{hours}:{minutes}:{seconds}");

    }

}
