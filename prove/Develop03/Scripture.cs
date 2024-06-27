public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] parts =  text.Split(" ");
        foreach (string part in parts)
        {
            Word word = new Word(part);
            _words.Add(word);
            
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int count = 0;
        bool hidden = true;
        

        while (numberToHide != count && IsCompletelyHidden() != true)
        {
            Word randomWord;
            int randomIndex = -1;
            
            do
            {
                Random random = new Random();
                randomIndex = random.Next(_words.Count());
                randomWord = _words[randomIndex];
                hidden = randomWord.IsHidden();
                
            } while (hidden == true);

            count += 1;

            string randomString = randomWord.GetDisplayText();

            Word hideWord = new Word(randomString);
            hideWord.Hide();

            _words[randomIndex] = hideWord;
        }  
    }

    public string GetDisplayText()
    {   
        List<string> stringWords = new List<string>();
        foreach (Word word in _words)
        {
            string wordDisplay = word.GetDisplayText();
            stringWords.Add(wordDisplay);
        }

        string words = String.Join(" ", stringWords);
    
        return words;
        
    }

    public bool IsCompletelyHidden()
    {   
        int hiddenCount = 0;

        foreach (Word word in _words)
        {
            if (word.IsHidden() == true)
            {
                hiddenCount += 1;
            }
        }

        if (hiddenCount == _words.Count())
        {
            return true;
        }
            
        else
        {
            return false;
        }
    }
}