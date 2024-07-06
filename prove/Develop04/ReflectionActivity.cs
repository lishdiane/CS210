using System.Security.Cryptography;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _reflections = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string name, string description, int time) : base(name, description, time)
    {

    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready.....");
        ShowSpinner(4);
        Console.WriteLine("");

        Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine("");

        Console.WriteLine("Press 'Enter' when you are ready to continue.");
        Console.ReadLine();
        Console.WriteLine("");

        Console.WriteLine("Now reflect on each of the following questions in relation to the prompt.");
        Console.WriteLine("");
        Console.Write("Beggining in: ");
        ShowCountDown(10);

        int time = GetTime();
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(time);

        Console.Clear();

        do 
        {
            Console.WriteLine($"> {GetRandomReflection()}");

            ShowSpinner(10);

            Console.WriteLine("");

            currentTime = DateTime.Now;

        }while (currentTime < futureTime);

        EndDisplay();
        ShowSpinner(4);

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count());

        string randomPrompt = _prompts[index];

        return randomPrompt;
    }

    public string GetRandomReflection()
    {
        Random random = new Random();
        int index = random.Next(_reflections.Count());

        string randomReflection = _reflections[index];

        return randomReflection;
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayReflection()
    {
        
    }
}