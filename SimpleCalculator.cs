using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ClassID: CLASS_ID | RegID: REG_ID | Name: Huzaifa Siddiqui | Date: 22-10-2026");

        Console.Write("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());

        switch (op)
        {
            case '+': Console.WriteLine("Result: " + (a + b)); break;
            case '-': Console.WriteLine("Result: " + (a - b)); break;
            case '*': Console.WriteLine("Result: " + (a * b)); break;
            case '/':
                if (b == 0) Console.WriteLine("Cannot divide by zero");
                else Console.WriteLine("Result: " + (a / b));
                break;
            default: Console.WriteLine("Invalid operator"); break;
        }
    }
}