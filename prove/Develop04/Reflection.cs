using System;

class Reflection : Activity
{
    public override void Start()
    {

        base.Start();

        Console.WriteLine("Welcome to the Reflecting Activity.\n");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. ");
        Console.WriteLine("\nHow long, in seconds, would you like for your session? ");

        int duration = Duration();
        int Durationused = duration;


        Random random = new Random();


        string[] prompts = {
            
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time you felt powerful.",
            "Think of a time where you felt calm."

        };


        string[] questions = {

            "Why was this experience meaningful to you?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"

        };


        string prompt = prompts[random.Next(prompts.Length)];

        Console.WriteLine(prompt + "\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.Read();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        
        Count(5);

        foreach (string question in questions)
        {

            Console.Write(question);
            Spinning(15);
            Durationused = 15;
            if (Durationused >= 0)

            {

                break;

            }
        }

        Spinning(3);
        Console.Clear();

    }
}