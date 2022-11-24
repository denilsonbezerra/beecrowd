using System;
using static System.Net.Mime.MediaTypeNames;

class URI
{

    static void Main(string[] args)
    {

        // Read an integer value corresponding to a person's age (in days)

        int ageInDays = int.Parse(Console.ReadLine());

        // Print it in years, months and days followed by its respective message “ano(s)”, “mes(es)”, “dia(s)”.

        int years = 0;
        int months = 0;
        int days = 0;

        for (years = 0; ageInDays >= 365; years++) {
            ageInDays -= 365;
        }

        for (months = 0; ageInDays >= 30; months++)
        {
            ageInDays -= 30;
        }

        for (days = 0; ageInDays > 0; days++)
        {
            ageInDays -= 1;
        }

        Console.WriteLine(
            $"{years} ano(s)\n" +
            $"{months} mes(es)\n" +
            $"{days} dia(s)"
            );

    }

}