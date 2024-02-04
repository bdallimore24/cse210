using System;

class Breathing : Activity
{

    public override void Start()
    {

        base.Start();

        Console.WriteLine("Welcome to the Breathing Activity.\n");
        Console.WriteLine("This activity will relax you by walking you through the art of breathing in and out slowly.");
        Console.WriteLine("Please clear your mind and focus on your breathing.\n");
        Console.WriteLine("How many seconds would you like this session to last? ");
        int duration = Duration();

        int total = duration;

        while (duration > 0)
        {
            Console.Write("Breathe in...");
            Count(4);

            Console.Write("Hold it...");
            Count(7);

            Console.Write("Breathe out...");
            Count(8);
            Console.WriteLine("");
            duration -= 19;

        }

        Console.Write("Good Job!!\n");
        Console.WriteLine($"\n You have completed this Breathing Activity in {total} seconds!");
        Spinning(3);
        Console.Clear();

    }
}