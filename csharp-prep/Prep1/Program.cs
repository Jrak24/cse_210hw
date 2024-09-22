using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first = Console.Readline();

        Console.Write("What is your last name? ");
        string last = Console.Readline();

        Console.Writeline($"Your name is {last}, {first} {last}. ");
    }
}