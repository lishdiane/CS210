public class Activity
{
    private string _name;
    private string _description;
    private int _time;

    public Activity(string name, string description, int time)
    {
        _name = name;
        _description = description;
        _time = time;
    }

    public void StartDisplay()
    {
        Console.WriteLine("");
    }

    public void EndDisplay()
    {
        Console.WriteLine("");
    }

    public void ShowSpinner(int seconds)
    {

    }

    public void ShowCountDown(int seconds)
    {

    }

    
}