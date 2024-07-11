using System.Diagnostics;
using System.Dynamic;
using System.Runtime.CompilerServices;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {

    }

    public void Start()
    {
        Console.Clear();

        string choice = "";
        List<string> menu = new List<string>()
        {
            "1. Create New Goal",
            "2. List Goals",
            "3. Save Goals",
            "4. Load Goals",
            "5. Record Event",
            "6. Reset Goals",
            "7. Reset Score",
            "8. Quit"
        };

        do
        {   
            Console.WriteLine("");
            Console.WriteLine("Welcome to the Eternal Quest!");
            Console.WriteLine("");
            Console.WriteLine("---------------");
            Console.WriteLine("Please select one of the menu options below: ");
            Console.WriteLine("");


            foreach ( string item in menu)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");
            Console.Write("Enter a number: ");
            choice = Console.ReadLine();
            Console.WriteLine("---------------");
            Console.WriteLine("");

            if (choice == "1")
            {
                CreateGoal();

                DisplayPlayerInfo();
            }

            else if (choice == "2")
            {
                ListGoalDetails();

                DisplayPlayerInfo();
            } 

            else if (choice == "3")
            {
                Console.WriteLine("What would you like to name your file? ");
                Console.Write("> ");
                string file = Console.ReadLine();

                SaveGoals(file);
            }

            else if (choice == "4")
            {
                Console.WriteLine("What is the name of the file you would like to load? ");
                Console.Write("> ");
                string fileName = Console.ReadLine();
                Console.WriteLine("");

                LoadGoals(fileName);
            }

            else if (choice == "5")
            {
                ListGoalDetails();
                Console.WriteLine("");
                RecordEvent();
            }

            else if (choice == "6")
            {
                Console.WriteLine("This will reset all the complete tasks to incomplete.");
                Console.WriteLine("Are you sure you want to reset all your goals? yes/no");
                string reset = Console.ReadLine();

                if (reset == "yes")
                {
                    ResetIsComplete();
                }
            }

            else if (choice == "7")
            {
                Console.WriteLine("This will reset your score to 0.");
                Console.WriteLine("Are you sure you want to reset your score? yes/no");
                string resetScore = Console.ReadLine();

                if (resetScore == "yes")
                {
                    _score = 0;
                }
            }

        } while (choice != "8"); 
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine("");
        Console.WriteLine($"You have score of {_score}.");
        Console.WriteLine("");
    }

    public void ListGoalNames()
    {   
         for (int i = 1; i <= _goals.Count; i ++)
        {
            int index = i - 1;

            string goal = _goals[index].GetStringRepresentation();
            string [] parts = goal.Split("|");

            Console.WriteLine($"{i}. {parts[1]}");
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 1; i <= _goals.Count; i ++)
        {
            int index = i - 1;

            Console.WriteLine($"{i}. {_goals[index].GetDetailsString()}");
        }

    }

    public void CreateGoal()
    {
        

        Console.WriteLine("What type of goal would you like to create? ");
        Console.WriteLine("");

        List<string> menu2 = new List<string>()
        {
            "1. Simple Goal",
            "2. Eternal Goal",
            "3. Checklist Goal"
        };

        foreach (string item in menu2)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("");
        Console.Write("What number option would you like? ");
        string choice2 = Console.ReadLine();
        Console.WriteLine("---------------");
        Console.WriteLine("");
        
        Console.WriteLine("What is the name of your goal?  ");
        Console.Write("> ");
        string name = Console.ReadLine();
        Console.WriteLine("");

        Console.WriteLine("Write a short description of your goal? ");
        Console.Write("> ");
        string description = Console.ReadLine();
        Console.WriteLine("");

        Console.WriteLine("How many points do you want this goal to be worth? ");
        Console.Write("> ");
        string pointsString = Console.ReadLine();
        Console.WriteLine("");

        int points = int.Parse(pointsString);

        if (choice2 == "1")
        {
            SimpleGoal simple = new SimpleGoal(name, description, points);

            _goals.Add(simple);
        }

        else if (choice2 == "2")
        {
            EternalGoal eternal = new EternalGoal(name, description, points);

            _goals.Add(eternal);
        }

        else if (choice2 == "3")
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a point bonus? ");
            Console.Write("> ");
            string targetString = Console.ReadLine();
            Console.WriteLine("");

            int target = int.Parse(targetString);

            Console.Write("How many bonus points would like this goal to have? ");
            string bonusString = Console.ReadLine();
            Console.WriteLine("");

            int bonus = int.Parse(bonusString);

            ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus);

            _goals.Add(checklist);
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("What event below would you like to record? ");
        Console.WriteLine("");

        ListGoalNames();
        
        Console.WriteLine(" ");
        Console.Write("Enter a number: ");
        string choiceString = Console.ReadLine();
        Console.WriteLine("---------------");
        Console.WriteLine("");

        int choiceNumber = int.Parse(choiceString);
        int index = choiceNumber - 1;

        _score += _goals[index].RecordEvent();

        DisplayPlayerInfo();
        Console.WriteLine("");

    }

    public void SaveGoals(string file)
    {
        using (StreamWriter writeText = new StreamWriter(file))
        {
            writeText.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writeText.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string file)
    {
        string firstLine = File.ReadLines(file).Take(1).First();
        _score = int.Parse(firstLine);

        _goals = [];

        string [] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines.Skip(1))
        {
            string [] parts = line.Split("|");

            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            
            if (type == "SimpleGoal")
            {
                SimpleGoal simple = new SimpleGoal(name, description, points);

                if (parts[4] == "True")
                {
                    simple.SetIsComplete(true);
                }

                _goals.Add(simple);
            }
            
            else if (type == "EternalGoal")
            {
                EternalGoal eternal = new EternalGoal(name, description, points);

                _goals.Add(eternal);
            }

            else if (type == "ChecklistGoal")
            {
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                int amountCompleted = int.Parse(parts[6]);

                ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus);
                checklist.SetAmountCompleted(amountCompleted);

                if (parts[7] == "True")
                {
                    checklist.SetIsComplete(true);
                }

                _goals.Add(checklist);
            }
        }
    }

    public void ResetIsComplete()
    {   
        foreach (Goal goal in _goals)
        {
            goal.ResetIsComplete();
        }

    }

}