public class Simple : Goal
{

    private bool _finished;

    public Simple(string name, string description, string points) : base(name, description, points)
    {

        _shortName = name;
        _description =description;
        _points = points;

    }

    public override void Record()
    {

        _finished = true;

    }

    public override bool Finished()
    {

        return _finished;

    }
    
    
    public override string GetStringRepresentation()
    {

        string representation = $"Simple Goal:{_shortName},{_description},{_points}";
        return representation;

    }
}