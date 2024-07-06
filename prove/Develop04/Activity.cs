

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
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
    }

    public void EndDisplay()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine("");
        Console.WriteLine($"You have completed {_time} seconds of the {_name}!");
    }

    public void ShowSpinner(int seconds)
    {
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(seconds);

        do
        {
            Console.Write($"\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");

            currentTime = DateTime.Now;
        }while (currentTime < futureTime);
    }

    public void ShowCountDown(int seconds)
    {
        
        do
        {
            Console.Write(seconds);
            Thread.Sleep(1000);

            if (seconds < 10)
            {
                Console.Write("\b \b");
                seconds -= 1;
            }

            else if (seconds >= 10 && seconds < 100)
            {
                Console.Write("\b \b");
                Console.Write("\b \b");
                seconds -= 1;
            }

            else if (seconds >= 100)
            {
                Console.Write("\b \b");
                Console.Write("\b \b");
                Console.Write("\b \b");
                seconds -= 1;
            }

        }while (seconds >= 0);

    }

    public int GetTime()
    {
        return _time;
    }

    public void SetTime(int time)
    {
        _time = time;
    }
}