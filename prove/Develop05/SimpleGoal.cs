public class SimpleGoal : Goal
{
     public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
    
    }

    public override int RecordEvent()
    {
        _isComplete = true;

        Console.WriteLine($"Congratulations!!! You have earned {_points} points!");
        Console.WriteLine("");
        
        return _points;
    }

    public override bool IsComplete()
    {
        if (_isComplete == false)
        {
            return false;
        }

        else
        {
            return true;
        }
        
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_name}|{_description}|{_points}|{_isComplete}";
    }

}