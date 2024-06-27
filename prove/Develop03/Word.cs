public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public Word()
    {
    }

    public void Hide()
    {
        int letterCount = _text.Count();
        string blanks = new string('_', letterCount);

        _text = blanks;
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        if (_isHidden == true)
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public string GetDisplayText()
    {
        return _text;
    }
}