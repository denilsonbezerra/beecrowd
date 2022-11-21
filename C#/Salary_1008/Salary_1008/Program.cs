using System;

class URI
{

    static void Main(string[] args)
    {
        // Write a program that reads an employee's number, his/her worked hours number in a month and the amount he received per hour. Print the employee's number and salary that he/she will receive at end of the month, with two decimal places.

        // Input contains 2 integer numbers and 1 value of floating point

        int Number = int.Parse(Console.ReadLine());
        int Hours = int.Parse(Console.ReadLine());
        decimal PerHour = decimal.Parse(Console.ReadLine());

        // Print the number and the employee's salary

        Console.WriteLine(
            $"NUMBER = {Number}\n" +
            $"SALARY = U$ {Hours * PerHour:F2}"
            );
    }
}
