using System;


public class Entry
{   

    public string date;
    public string prompt;
    public string entry;

    public void DisplayEntry()
    {

        Console.WriteLine($"Date: {date}");

        Console.WriteLine($"{prompt}");

        Console.WriteLine($"{entry}\n");
        
    }
}