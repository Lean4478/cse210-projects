using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Please, enter your grade percentage: ");

        int percentage = int.Parse(Console.ReadLine());

        string letterGrade = "";

        if (percentage >= 90)
        {
            letterGrade = "A";
        }

        else if (percentage >= 80)
        {
            letterGrade = "B";
        }

        else if (percentage >= 70)
        {
            letterGrade = "C";
        }

        else if (percentage >= 60)
        {
            letterGrade = "D";
        }

        else
        {
           letterGrade = "F"; 
        }

        Console.Write($"Your letter grade is: {letterGrade}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratularion!! You passed the class");
        }

        else
        {
            Console.WriteLine("Sorry, you did not pass the class. Better luck next time!");
        }

    }
}