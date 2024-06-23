public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was your favorite thing you did today?", 
        "Is there anything you would change about the day?", 
        "Write about the people you are grateful for.", 
        "What are some things that bring you joy?", 
        "What is something that makes you proud of yourself?", 
        "Who is your hero? Why?"
    };

    public string GetRandomPrompt()
    {
        Random randomNumber = new Random();
        int randomIndex = randomNumber.Next(_prompts.Count);

        string prompt = _prompts[randomIndex];
        
        return prompt;
    }
}