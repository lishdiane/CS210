public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        string [] _prompts = 
        [
            "What was your favorite thing you did today?", 
            "Is there anything you would change about the day?", 
            "Write about the people you a grateful for.", 
            "What are some things that bring you joy?", 
            "What is something that makes you proud of yourself?", 
            "Who is your hero? Why?"
        ];
        
        string prompt = Random.Shared.GetItems(_prompts, 1)[0];
        return prompt;
    }
}