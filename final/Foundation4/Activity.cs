using System;

public abstract class Activity
{
    public Activity(string date, int length)
    {

        _date = date;
        _length = length;

    }

    protected string _date;
    protected int _length;
    protected string _activity;

    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();
    
    public virtual void GetSummary()
    {
        
        Console.WriteLine($"{_date} {_activity} ({_length} minutes)- Distance {Distance()} miles, {Speed()} MPH, {Pace()} min per mile");

    }
}