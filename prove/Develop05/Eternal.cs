public class Eternal : Goal
{

    DateTime _rightNow = DateTime.Now;

    int _streak;
    
    
    public Eternal(string name, string description, string points, int streak) : base(name, description, points)
    {

        _shortName = name;
        _description = description;
        _points = points;
        _streak = streak;

    }

    public override void Record()
    {

        DateTime _today = _rightNow.Date;
        DateTime _tomorrow = _today.AddDays(1);
        Console.WriteLine("Nice!");
        if (DateTime.Now.Date == _tomorrow){
            _streak += 1;
            
        }

        else
        {

            _streak = 0;
            Console.WriteLine("Your streak got broken. What a shame!");
            Console.WriteLine("Well next time good luck!");

        }

        if(_streak == 30)
        {

            Console.WriteLine("Well done! This habit was formed!");
            _points = "500";

        }
    }

    public override bool Finished()
    {

        return false;

    }

  
    public override string GetStringRepresentation()
    {

        string representation = $"Eternal Goal:{_shortName},{_description},{_points}";
        return representation;

    }
}