using System;

class Program
{
    
    static void Main(string[] args)
    {
        
        Console.Clear();
        List<Activity> activitiesList = new List<Activity>();

        activitiesList.Add(new Run(4, "March 7", 46));
        activitiesList.Add(new Bike(22, "May 17", 26));
        activitiesList.Add(new Swim(8, "June 16", 20));

        foreach (Activity act in activitiesList)
        {

            act.GetSummary();

        }
    }
}