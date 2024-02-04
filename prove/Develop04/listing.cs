using System;

class Listing : Activity
{

    public override void Start()
    {

        Random random = new Random();
        string[] prompts = 
        {

            "What do you find relaxing?",
            "What do you find challenging?",
            "What do you find fulfilling?",
            "What do you find frustrating?",
            "What do you find funny?",
            "What do you find beautiful?",
            "What do you find meaningful?",
            "What do you find exciting?",
            "What do you find scary?",
            "What do you find confusing?",
            "What do you find interesting?",
            "What do you find enjoyable?",
            "What do you find challenging?",
            "What do you find rewarding?",
            "What do you find inspiring?",
            "What do you find humbling?",
            "What do you find overwhelming?",
            "What do you find peaceful?",
            "What do you find hopeful?",
            "What do you find motivating?",
            "What do you find empowering?",
            "What do you find fascinating?",
            "What do you find amusing?",
            "What do you find impressive?",
            "What do you find heartwarming?",
            "What do you find thought-provoking?"

        };

        string prompt = prompts[random.Next(prompts.Length)];


        Console.WriteLine("Welcome to the Listing Activity");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        int timeLimit = Duration();


        DateTime deadline = DateTime.Now.AddSeconds(timeLimit);


        base.Start();

        Console.WriteLine("List as many responses as you can to the following prompt:\n\n");
        Console.WriteLine($"--- {prompt} ---\n");
        Console.Write("You may begin in: ");
        Count(5);

        int listcount = 0;
        while (DateTime.Now < deadline)
        {
            Console.Write("> ");
            Console.ReadLine();
            listcount++;
        }

        Console.WriteLine($"Well done!\n \n You have listed {listcount} items.");
        Spinning(3);
        Console.Clear();

    }
}