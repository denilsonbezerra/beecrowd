using System;

class URI
{

    static void Main(string[] args)
    {

        // Read an integer value, which is the duration in seconds of a certain event in a factory

        int duration = int.Parse(Console.ReadLine());

        // Inform it expressed in hours:minutes:seconds

        int hours = 0;
        int minutes = 0;

        for (hours = 0; duration >= 3600; hours++)
        {
            duration -= 3600;
        }

        for (minutes = 0; duration >= 60; minutes++)
        {
            duration -= 60;
        }

        int seconds = duration;

        Console.WriteLine($"{hours}:{minutes}:{seconds}");

    }

}