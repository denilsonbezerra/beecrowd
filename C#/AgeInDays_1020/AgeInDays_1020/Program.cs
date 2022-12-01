using System;

class URI
{

    static void Main(string[] args)
    {

        int ageInDays = int.Parse(Console.ReadLine());

        int[] yearMonthAndDay = { 365, 30, 1 };

        foreach (int days in yearMonthAndDay) {

            int convertedDate = ageInDays / days;
            ageInDays -= convertedDate * days;

            if (days == 365) {
                Console.WriteLine($"{convertedDate} ano(s)");
            } else if (days == 30) {
                Console.WriteLine($"{convertedDate} mes(es)");
            } else {
                Console.WriteLine($"{convertedDate} dia(s)");
            }

        }

    }

}
