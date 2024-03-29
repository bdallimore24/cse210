using System;

class Program
{

    static void Main(string[] args)
    {

        bool loop = true;
        int choice;
        string input;
        while (loop)
        {

            Console.WriteLine("Mindfulness Activities:\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit\n");
            Console.Write("Choose an activity (1-4): ");
            input = Console.ReadLine();


            if (int.TryParse(input, out choice))
            {

                switch (choice)
                {

                    case 1:
                        Console.Clear();
                        Breathing bActivity = new Breathing();
                        bActivity.Start();
                        break;

                    case 2:
                        Console.Clear();
                        Reflection rActivity = new Reflection();
                        rActivity.Start();
                        break;

                    case 3:
                        Console.Clear();
                        Listing lActivity = new Listing();
                        lActivity.Start();
                        break;

                    case 4:
                        Console.Clear();
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("Choice not valid. Try again.");
                        break;

                }
            }

            else

            {

                Console.Clear();

            }
        }
    }

    static int GetDuration()
    {

        int duration;

        while (true)
        {

            Console.Write("Enter the desired duration in seconds: ");

            if (int.TryParse(Console.ReadLine(), out duration) && duration > 0)
            {

                return duration;

            }

            Console.WriteLine("Input not valid. Please only enter a positive numbers.");

        }
    }
}