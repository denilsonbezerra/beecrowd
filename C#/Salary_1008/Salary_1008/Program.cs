using System;

class URI
{

    static void Main(string[] args)
    {

        int number = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        decimal perHour = decimal.Parse(Console.ReadLine());

        Console.WriteLine(
            $"NUMBER = {number}\n" +
            $"SALARY = U$ {hours * perHour:F2}"
            );
        
    }
    
}
