using System;

class URI
{
    
    static void Main(string[] args)
    {

        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(number);

        int[] banknotes = { 100, 50, 20, 10, 5, 2, 1 };

        foreach (int banknote in banknotes) {

            int banknoteNum = number / banknote;
            number -= banknote * banknoteNum;

            Console.WriteLine($"{banknoteNum} nota(s) de R$ {banknote},00");
            
        }
        
    }
    
}
