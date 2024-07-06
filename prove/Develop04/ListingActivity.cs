using System.IO.Compression;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _listFromUser = new List<string>();
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };


    public ListingActivity(string name, string description, int time) : base(name, description, time)
    {

    }

    public void Run()
    {
        Console.Clear();

        Console.WriteLine("Get ready.....");
        ShowSpinner(4);

        Console.Clear();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine("");
        
        Console.Write("Get ready to list items beggining in: ");
        ShowCountDown(10);
        Console.WriteLine("");

        int time = GetTime();
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(time);

        do
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            
            _listFromUser.Add(item);

            currentTime = DateTime.Now;

        }while (currentTime < futureTime);

        _count = _listFromUser.Count();

        Console.WriteLine("");
        Console.WriteLine($"You've listed {_count} items.");
        Console.WriteLine("");

        EndDisplay();
        ShowSpinner(10);

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count());

        string randomPrompt = _prompts[index];

        return randomPrompt;
    }

    public List<string> GetListFromUser()
    { 
        return  _listFromUser;
    }

}