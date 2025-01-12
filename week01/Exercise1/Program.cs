using System;

class Program
{
    static void Main(string[] args)
    {

        //TRYING C#
        Console.Write("What is your favorite color?");
        string color = Console.ReadLine();
        Console.WriteLine($"Your favorite color is {color}");

        Console.Write("What is your name?");
        string name = Console.ReadLine();
        Console.Write("What is your last name?");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {name} {lastName}");

    }      
}