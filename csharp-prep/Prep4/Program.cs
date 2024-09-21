using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a list of numbers, type 0 when finished.");
        string input = Console.ReadLine();
        List<int> numbers = new List<int>();

        while (input != "0")
        {
            Console.Write("Enter a number: ");
            numbers.Add(int.Parse(input));
            input = Console.ReadLine();
            if (input == "0")
                break;
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The Sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int maxNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}