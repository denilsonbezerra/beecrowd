using System;

class URI
{

    static void Main(string[] args)
    {
        // Make a program that reads a seller's name, his/her fixed salary and the sale's total made by himself/herself in the month (in money)

        // The input contains a text (employee's first name), and two double precision values, that are the seller's salary and the total value sold by him/her

        string name = Console.ReadLine();
        double salary = double.Parse(Console.ReadLine());
        double sold = double.Parse(Console.ReadLine());

        // Considering that this seller receives 15% over all products sold, write the final salary (total) of this seller at the end of the month, with two decimal places

        double TOTAL = (sold * 15 / 100) + salary;
        
        Console.WriteLine($"TOTAL = R$ {TOTAL:F2}");
    }
}
