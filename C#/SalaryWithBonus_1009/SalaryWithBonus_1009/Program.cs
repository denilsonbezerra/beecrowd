using System;

class URI
{

    static void Main(string[] args)
    {

        string name = Console.ReadLine();
        double salary = double.Parse(Console.ReadLine());
        double sold = double.Parse(Console.ReadLine());

        double TOTAL = (sold * 15 / 100) + salary;
        
        Console.WriteLine($"TOTAL = R$ {TOTAL:F2}");
        
    }
    
}
