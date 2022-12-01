using System;

class URI
{

    static void Main(string[] args)
    {
        
        string[] line1 = Console.ReadLine().Split(' ');
        int prod1 = int.Parse(line1[0]);
        int unitsProd1 = int.Parse(line1[1]);
        decimal priceProd1 = decimal.Parse(line1[2]);
        decimal total1 = unitsProd1 * priceProd1;

        string[] line2 = Console.ReadLine().Split(' ');
        int prod2 = int.Parse(line2[0]);
        int unitsProd2 = int.Parse(line2[1]);
        decimal priceProd2 = decimal.Parse(line2[2]);
        decimal total2 = unitsProd2 * priceProd2;

        Console.WriteLine($"VALOR A PAGAR: R$ {(total1 + total2):F2}");
        
    }
    
}
