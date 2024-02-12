public class Checklist : Goal

{

    private int _target;

    public int _bonus;

    private int _currentCompleted;

    public  Checklist(string name, string description, string points, int target, int bonus, int currentCompleted) : base(name,description,points)
    {

        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
        _currentCompleted = currentCompleted;

    }
    
    public override void Record()
    {

        _currentCompleted += 1;

    }

    public override bool Finished()
    {

        if (_currentCompleted == _target)
        {

            return true;

        }
        else
        {

            return false;

        }
    }
    public override string GetStringRepresentation()
    {

       string representation = $"Checklist: {_shortName},{_description},{_points},{_bonus},{_target},{_currentCompleted}";

        return representation;

    }

    public override string GetDetailsString()
    {

         string checkBox;
        bool complete = Finished();
        if (complete == true){
            checkBox = "X";

        }
        
        else
        {

            checkBox = " ";

        }

        string details = $"[{checkBox}] {_shortName} ({_description}) - Currently Completed: {_currentCompleted}/{_target} ";
        
        return details;
    }
}