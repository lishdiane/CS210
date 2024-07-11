
public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete = false;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        if (IsComplete() == true)
        {
            return $"[X] {_name} ({_description})";
        }
        else
        {
            return $"[ ] {_name} ({_description})";
        }
    }

    public abstract string GetStringRepresentation();

    public void SetIsComplete(bool value)
    {   
        _isComplete = value;
    }
    public virtual void ResetIsComplete()
    {
        _isComplete = false;
    }

}
