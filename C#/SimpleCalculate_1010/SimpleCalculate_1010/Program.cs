using System;

class URI
{

    static void Main(string[] args)
    {
        // Read a code of a product 1, the number of units of product 1, the price for one unit of product 1, the code of a product 2, the number of units of product 2 and the price for one unit of product 2
        // The input contains two lines of data. In each line there will be 3 values: two integers and a floating value with 2 digits after the decimal point

        #region Product 1

        string[] line1 = Console.ReadLine().Split(' ');
        int prod1 = int.Parse(line1[0]);
        int unitsProd1 = int.Parse(line1[1]);
        decimal priceProd1 = decimal.Parse(line1[2]);
        decimal total1 = unitsProd1 * priceProd1;

        #endregion

        #region Product 2

        string[] line2 = Console.ReadLine().Split(' ');
        int prod2 = int.Parse(line2[0]);
        int unitsProd2 = int.Parse(line2[1]);
        decimal priceProd2 = decimal.Parse(line2[2]);
        decimal total2 = unitsProd2 * priceProd2;

        #endregion

        // The value must be presented with 2 digits after the point

        Console.WriteLine($"VALOR A PAGAR: R$ {(total1 + total2):F2}");
    }
}