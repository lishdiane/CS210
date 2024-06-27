public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        string chapter = _chapter.ToString();
        string verse = _verse.ToString();
        string endVerse = _endVerse.ToString();

        if (_endVerse > 0)
        {
            return $"{_book} {chapter}:{verse}-{endVerse} ";
        }

        else if (_endVerse <= 0)
        {
            return $"{_book} {chapter}:{verse} ";
        }

        else
        {
            return "Not in proper format.";
        }


    }
}