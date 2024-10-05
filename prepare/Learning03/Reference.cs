public class Reference
{
    private string _referenceText; // Store the reference as a simple string

    // Constructor that accepts a single string for the reference text
    public Reference(string referenceText)
    {
        _referenceText = referenceText; // Initialize the reference text
    }

    // Return the reference text when needed
    public override string ToString()
    {
        return _referenceText; // Return the reference in string format
    }
}
