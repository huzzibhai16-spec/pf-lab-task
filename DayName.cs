using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ClassID: CLASS_ID | RegID: REG_ID | Name: Huzaifa Siddiqui | Date: 22-10-2026");

        Console.Write("Enter day number (1-7): ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int day) && day >= 1 && day <= 7)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Console.WriteLine(days[day - 1]);
        }
        else
        {
            Console.WriteLine("Invalid number");
        }
    }
}