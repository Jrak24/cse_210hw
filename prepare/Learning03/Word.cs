public class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor to initialize a word
    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Words start as visible
    }

    // Hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Get the display word, either the actual word or underscores if hidden
    public string GetDisplayWord()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}
