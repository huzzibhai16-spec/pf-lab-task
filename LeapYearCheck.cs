using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ClassID: CLASS_ID | RegID: REG_ID | Name: Huzaifa Siddiqui | Date: 22-10-2026");

        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            Console.WriteLine(year + " is a leap year");
        else
            Console.WriteLine(year + " is not a leap year");
    }
}