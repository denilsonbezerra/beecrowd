using System;

class URI {

    static void Main(string[] args) {

        // Write an algorithm that reads two floating values (x and y), which should represent the coordinates of a point in a plane
        // Next, determine which quadrant the point belongs, or if you are at one of the Cartesian axes or the origin (x = y = 0)
        // If the point is at the origin, write the message "Origem"
        // If the point is at X axis write "Eixo X", else if the point is at Y axis write "Eixo Y"

        string[] coordinates = Console.ReadLine().Split(' ');

        float coordinateX = float.Parse(coordinates[0]);
        float coordinateY = float.Parse(coordinates[1]);

        if (coordinateX != 0 && coordinateY == 0) {
            Console.WriteLine("Eixo X");
        } else if (coordinateX == 0 && coordinateY != 0) {
            Console.WriteLine("Eixo Y");
        } else if (coordinateX > 0 && coordinateY > 0) {
            Console.WriteLine("Q1");
        } else if (coordinateX < 0 && coordinateY > 0) {
            Console.WriteLine("Q2");
        } else if (coordinateX < 0 && coordinateX < 0) {
            Console.WriteLine("Q3");
        } else if (coordinateX > 0 && coordinateY < 0) {
            Console.WriteLine("Q4");
        }  else {
            Console.WriteLine("Origem");
        }

    }

}