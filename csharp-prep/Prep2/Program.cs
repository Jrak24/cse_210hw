using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user for their grade percentage
        Console.WriteLine("What is your grade percentage? ");
        string answer = Console.ReadLine();
        
        // Try parsing the input, handle invalid input gracefully
        try
        {
            int percent = int.Parse(answer);
            string letter = "";

            // Determine the letter grade based on percentage
            if (percent >= 90)
            {
                letter = "A";
            }
            else if (percent >= 80)
            {
                letter = "B";
            }
            else if (percent >= 75)
            {
                letter = "C-";
            }
            else if (percent >= 70)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            // Output the letter grade
            Console.WriteLine($"Your grade is: {letter}");

            // Display a message based on the grade
            if (percent >= 75)
            {
                Console.WriteLine("You're lucky you passed!");
            }
            else
            {
                Console.WriteLine("Do better next time!");
            }
        }
        catch (FormatException)
        {
            // If input is not a valid number, show an error message
            Console.WriteLine("Invalid input! Please enter a valid number for the grade percentage.");
        }
    }
}
