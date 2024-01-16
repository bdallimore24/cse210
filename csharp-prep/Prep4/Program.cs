using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> num = new List<int>();
        int userpick = -1;
        while (userpick != 0)
        {
    
        Console.Write("Enter a number (0 to quit): ");
            
        string userResponse = Console.ReadLine();
        userpick = int.Parse(userResponse);
            
        if (userpick != 0)
        {

            num.Add(userpick);

        }

    }

        int sum = 0;
        foreach (int number in num)
        {

            sum += number;

        }

        Console.WriteLine($"The sum is: {sum}");
        float avg = ((float)sum) / num.Count;

        Console.WriteLine($"The average is: {avg}");
        int max = num[0];

        foreach (int number in num)
        {
            if (number > max)
            {

                max = number;

            }
        }

        Console.WriteLine($"The largest number is: {max}");

    




    }
}