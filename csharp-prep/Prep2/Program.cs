using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string answer = Console.Readline();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B".
        }
        else if (percent >=75)
        {
            letter = "C-";
        }
        else if (percent >= 70)
        {
            letter = "D"
        }
        else{
            letter = "F";
        }

        Console.Writeline($"Your grade is: {letter}");

        if (percent >= 75)
        {
            Console.Writeline("You're lucky you passed!");
        }
        else
        {
            Console.Writeline("Do better next time!");
        }
    }
}