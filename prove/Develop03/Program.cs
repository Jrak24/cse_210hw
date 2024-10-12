using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Initialize a scripture
            Scripture scripture = new Scripture("John 3:16", "For God so loved the world that He gave His only begotten Son");

            // Step 2: Main program loop
            while (true)
            {
                Console.Clear();  // Clear the console screen
                scripture.Display();  // Display the scripture

                // Check if all words are hidden
                if (scripture.AllWordsHidden())
                {
                    Console.WriteLine("All words hidden! You've successfully memorized the scripture.");
                    break;
                }

                // Step 3: Prompt the user to hide more words or quit
                Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit.");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    break;
                }

                // Step 4: Hide random words
                scripture.HideRandomWords();
            }
        }
    }
}
