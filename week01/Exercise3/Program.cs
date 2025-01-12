using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int magicNumber = random.Next(1,101);

        int userGuess;

        Console.WriteLine("Guess a magic number between 1 and 100: ");

        do
        
        {

            Console.Write("Your guess: ");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess < magicNumber)
            {
                Console.WriteLine("Too low! Higher");
            }

            else if (userGuess > magicNumber)

            {
                Console.WriteLine("Too high! Lower");
            }

            else 
            {
                Console.WriteLine("You guessed it");
            }
        } while (userGuess != magicNumber);

    }
}