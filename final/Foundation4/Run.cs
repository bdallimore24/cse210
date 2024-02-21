public class Run : Activity
{
    
    int _distance;

    public Run(int distance, string date, int length) : base (date, length)
    {

        _distance = distance;

    }

    public override double Distance()
    {

        return this._distance;

    }

    public override double Speed()
    {

        return (Distance() / _length) * 60;

    }

    public override double Pace()
    {

        return 60 / Speed();

    }

    public override void GetSummary()
    {

        _activity = "Run";
        base.GetSummary();
        
    }
}