using System;
using System.Threading;

abstract class Activity
{
    public virtual void Start()
    {
        Console.Write("Get ready...");
        Count(3);
        Console.WriteLine();
    }

    protected void Count(int x)
    {

    
        for (int i = x; i >= 0; i--)
        {

            Console.Write(i);
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);

        }

        Console.WriteLine(" ");

    }


    protected void Spinning(int x)

    {
        string[] spinning = { "|", "/", "-", "\\" };
        int spinningIndex = 0;
        for (int i = 0; i < x*4; i++)

        {

            Console.Write(spinning[spinningIndex % spinning.Length] + " ");
            spinningIndex++;
            Thread.Sleep(250);
            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);

        }

        Console.WriteLine(" ");

    }

    protected int Duration()
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