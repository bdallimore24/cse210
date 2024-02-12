using System.IO;

public class Manager{

    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void Start()
    {

        string choice = "0";

        Console.Clear();
        {

        DisplayPlayerInfo();

        

        Console.WriteLine("\nWelcome to the Goal program! Please choose an option.\n");

        System.Console.WriteLine("1. Create New Goal");
        System.Console.WriteLine("2. List Goals");
        System.Console.WriteLine("3. Save Goals");
        System.Console.WriteLine("4. Load Goals");
        System.Console.WriteLine("5. Record Event");
        System.Console.WriteLine("6. Quit");

        System.Console.WriteLine("\nEnter your choice: ");

        choice = Console.ReadLine();

        if (choice == "1")
        {

            CreateGoal();

        }

        else if(choice == "2")
        {

            ListGoalDetails();

        }

        else if(choice == "3")
        {

            SaveGoal();

        }

        else if(choice == "4")
        {

            LoadGoal();

        }

        else if(choice == "5")
        {

            Record();

        }
        
        }
        
        while(choice != "6");
 
    }

    public void DisplayPlayerInfo()
    {

        Console.WriteLine($"You have {_score} points.");

    }

    public void ListGoalNames()
    {

       Console.WriteLine("1.Simple Goal");
       Console.WriteLine("2.Eternal Goal");
       Console.WriteLine("3.Checklist goal");

    }

    public void ListGoalDetails()
    {

        int goalNumber = 0;

        foreach(Goal goal in _goals)
        {

            string details = goal.GetDetailsString();
            goalNumber += 1;
            Console.WriteLine($"{goalNumber}. {details}");

        }
    }

    public void CreateGoal()
    {

        Console.WriteLine("Which goal would you like to make?");
        ListGoalNames();

        Console.Write("> ");

        string desiredGoal = Console.ReadLine();

        Console.WriteLine("What is the name of your goal? ");
        Console.Write("> ");

        string name = Console.ReadLine();

        Console.WriteLine("What is this goal about?");
        Console.Write("> ");

        string description = Console.ReadLine();

        Console.WriteLine("How many points do you want this goal to be worth ?");
        Console.Write("> ");

        string points = Console.ReadLine();


        if(desiredGoal == "1")
        {

            Simple simple = new Simple(name,description,points);
            _goals.Add(simple);

        }

        else if(desiredGoal == "2")
        {

            Eternal eternal = new Eternal(name,description,points,0);
            _goals.Add(eternal);

        }

        else if(desiredGoal == "3")
        {

            Console.WriteLine("How many times do you want to complete this goal?");
            Console.Write(">");

            string targetText = Console.ReadLine();

            Console.WriteLine("What is the bonus for accoplish that many times? ");
            Console.Write("> ");

            string bonusText = Console.ReadLine();

            int target = Int32.Parse(targetText);
            int bonus = Int32.Parse(bonusText);

            Checklist checklist = new Checklist(name,description,points,target,bonus,0);
            _goals.Add(checklist);

        }
    }
    
    public void Record()
    {

        ListGoalDetails();
        Console.WriteLine("Which goal would you like to make a record for?");
        Console.Write("> ");

        string goalPickerText = Console.ReadLine();
        int goalPicker = Int32.Parse(goalPickerText);
        goalPicker -= 1;
        Goal goal = _goals[goalPicker];
        goal.Record();

        int points = Int32.Parse(goal._points);
        _score += points;

    }

    public void SaveGoal()
    {

        using (StreamWriter outputFile = new StreamWriter("goal.txt"))
        {

            outputFile.WriteLine($"{_score}");

            foreach(Goal goal in _goals)
            {

                string representation = goal.GetStringRepresentation();
                outputFile.WriteLine(representation);

            }
        }
    }

    public void LoadGoal()
    {

        string line1 = File.ReadLines("goal.txt").First();
        int totalPoints = Int32.Parse(line1);
        _score += totalPoints;

        string[] lines = System.IO.File.ReadAllLines("goal.txt");
        List<string> goalList = new List<string>();

        foreach (string line in lines)
        {

            goalList.Add(line);

        }

            goalList.RemoveAt(0);

            foreach(string line in goalList)
            {

                string[] parts = line.Split(":");
                string goalType = parts[0];
                string goal = parts[1];

                if(goalType == "Simple")
                {

                    string[] goalParts = parts[1].Split(",");
                    string name = goalParts[0];
                    string description = goalParts[1];
                    string points = goalParts[2];
                    
                    Simple simple = new Simple(name, description, points);
                    _goals.Add(simple);

            }

            else if (goalType == "Eternal")
            {

                string[] Parts = parts[1].Split(",");
                string name = Parts[0];
                string description = Parts[1];
                string points = Parts[2];
                string streakText = Parts[3];

                int streak = Int32.Parse(streakText);
                Eternal eternal = new Eternal(name,description,points,streak);
                _goals.Add(eternal);

            }

            else if (goalType == "Checklist")
            {

                string[] Parts = parts[1].Split(",");
                string name = Parts[0];
                string description = Parts[1];
                string points = Parts[2];
                string bonusText = Parts[3];

                int bonus = Int32.Parse(bonusText);

                string targetText = Parts[4];

                int target = Int32.Parse(targetText);

                string amountCompletedText = Parts[5];

                int amountCompleted = Int32.Parse(amountCompletedText);
                
                Checklist checklist = new Checklist(name,description,points,target,bonus,amountCompleted);
                _goals.Add(checklist);   

                }

            }
        }
    }