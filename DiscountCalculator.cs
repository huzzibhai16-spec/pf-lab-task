using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ClassID: CLASS_ID | RegID: REG_ID | Name: Huzaifa Siddiqui | Date: 22-10-2026");

        Console.Write("Enter purchase amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        double discountPercent;
        if (amount >= 5000)
            discountPercent = 20;
        else if (amount >= 2000)
            discountPercent = 10;
        else
            discountPercent = 0;

        double discountAmount = amount * discountPercent / 100;
        double finalAmount = amount - discountAmount;

        Console.WriteLine("Discount Percentage: " + discountPercent + "%");
        Console.WriteLine("Discount Amount: " + discountAmount);
        Console.WriteLine("Final Payable Amount: " + finalAmount);
    }
}