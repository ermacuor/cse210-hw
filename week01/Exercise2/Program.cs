using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        string letter = "";
        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        string symbol = "";
        if (number % 10 >= 7)
        {
            symbol = "+";
        }
        else if (number % 10 < 3)
        {
            symbol = "-";
        }

        if (number >= 97)
        {
            Console.Write($"Your letter grade is {letter}.");
        }
        else if (number < 97)
        {
            Console.Write($"Your letter grade is {letter}{symbol}.");
        }
    }   
}