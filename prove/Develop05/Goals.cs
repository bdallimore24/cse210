public abstract class Goal
{

    protected string _shortName;

    protected string _description;

    public string _points;

    public Goal(string name, string description, string points)
    {

        _shortName = name;
        _description = description;
        _points = points;

    }

    public abstract void Record();

    public abstract bool Finished();

    public virtual string GetDetailsString()
    {

        string checkBox;
        bool complete = Finished();

        if (complete == true)
        {

            checkBox = "X";

        }
        else{
            checkBox = " ";
        }
        string details = $"[{checkBox}] {_shortName} ({_description})";
        return details;
    }
    public abstract string GetStringRepresentation();

}