using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Clear();
        List<Activity> activitiesList = new List<Activity>();

        activitiesList.Add(new Run(4, "March 7", 43));
        activitiesList.Add(new Bike(22, "May 17", 26));
        activitiesList.Add(new Swim(9, "June 16", 17));

        foreach (Activity act in activitiesList)
        {

            act.GetSummary();

        }
    }
}