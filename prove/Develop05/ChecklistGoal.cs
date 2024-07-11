public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base (name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted += 1;

        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Congratulations!!! You have Completed this event and earned {_bonus} bonus points!");
            Console.WriteLine($"You have earned a total of {_points + _bonus} points!");
            Console.WriteLine("");

            _isComplete = true;

            return _points + _bonus;
        }

        else
        {
           Console.WriteLine($"Congratulations!!! You have earned {_points} points!");
           Console.WriteLine("");

            return _points;
        }

    }

    public override bool IsComplete()
    {
        
        if(_amountCompleted == _target || _isComplete == true)
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }

      public override void ResetIsComplete()
    {
        _amountCompleted = 0;
        _isComplete = false;
    }
    public override string GetDetailsString()
    {
        if (IsComplete() == true)
        {
            return $"[X] {_name} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }

        else
        {
            return $"[ ] {_name} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}|{_isComplete}";
    }
}