using System;

class URI
{

    static void Main(string[] args)
    {
        // Two cars leave in the same direction. The car X leaves with a constant speed of 60 km/h and the car Y leaves with a constant speed of 90 km / h
        // In one hour the car Y can get a distance of 30 kilometers from the X car, in other words, it can get away one kilometer for each 2 minutes
        // The input file contains 1 integer value
        // Read the distance (in km)

        int distance = int.Parse(Console.ReadLine());

        // Calculate how long it takes (in minutes) for the car Y to take this distance in relation to the other car

        int time = distance * 2;

        // Print the necessary time followed by the message "minutos" that means minutes in Portuguese

        Console.WriteLine($"{time} minutos");
    }
}