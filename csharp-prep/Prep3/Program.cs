using System;

class Program
{
    static void Main(string[] args)

    {
        Console.Write("Pick a number between 1 and 100:  ");
        Random randomGenerator = new Random();
        int theguess = randomGenerator.Next(1, 100);

        int guess = -1;

        while (guess != theguess)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (theguess > guess)
            {

                Console.WriteLine("Higher");

            }

            else if (theguess < guess)
            {

                Console.WriteLine("Lower");

            }

            else
            {

                Console.WriteLine("You guessed it!");

            }
        }
    }
}