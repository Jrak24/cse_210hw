public class Scripture 
{
    private Reference _reference; // Use the custom Reference class
    private List<Word> _words;

    public Scripture(string referenceText, string scriptureText)
    {
        _reference = new Reference(referenceText); // Initialize Reference
        _words = scriptureText.Split(' ').Select(word => new Word(word)).ToList(); // Split scripture text into words
    }

    // Display the scripture with hidden words replaced by underscores
    public void Display()
    {
        Console.WriteLine(_reference.ToString()); // Display reference
        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayWord() + " "); // Display each word or underscores if hidden
        }
        Console.WriteLine();
    }

    // Randomly hide words in the scripture
    public void HideRandomWords()
    {
        Random random = new Random(); // Create a random number generator
        int index = random.Next(_words.Count); // Get a random index
        _words[index].Hide(); // Hide the word at that index
    }

    // Check if all words are hidden
    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden()); // Return true if all words are hidden
    }
}
