using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string input = Console.ReadLine();
        int percent = int.Parse(input);

        string letter = "";

        if (percent >= 90)
        {

            letter = "A";

        }

        else if (percent >= 80)
        { 
            
            letter = "B";

        }

        else if (percent >= 70)
        {

            letter = "C";
            
        }

        else if (percent >= 60)
        {

            letter = "D";

        }

        else
        {

            letter = "F";

        }

        Console.WriteLine($"Your grade is: {letter}");

        if (percent >= 70)
        {

            Console.WriteLine("Oh good, you passed! I was worried");

        }

        else
        {

            Console.WriteLine("Well. . . Better luck next time!");

        }

    }
}