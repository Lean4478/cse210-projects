using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userInput;

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        do

        {
            Console.Write("Enter a number :");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        } while (userInput != 0);

        Console.WriteLine("You entered the following numbers: ");

        foreach (int number in numbers)

        {
            Console.WriteLine(number);
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        if (numbers.Count > 0)
        {
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");
        }

        if (numbers.Count > 0)
        {
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($" The largest number is: {max}");
        }

    }
}