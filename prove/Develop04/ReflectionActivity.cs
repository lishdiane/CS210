public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _reflections = new List<string>();

    public ReflectionActivity(string name, string description, int time) : base(name, description, time)
    {

    }

    public void Run()
    {

    }

    public string GetRandomPrompt()
    {
        return "";
    }

    public string GetRandomReflection()
    {
        return "";
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayReflection()
    {
        
    }
}