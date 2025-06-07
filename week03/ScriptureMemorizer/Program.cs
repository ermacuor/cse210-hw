using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Reference ref1 = new Reference("Probervs", 3, 16, 6);

        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(ref1, text);

        Console.Clear();
       
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.Write("Press enter to continue or type 'quit' to finish: ");

            string input = Console.ReadLine();
            if (input != null)
                {
                    input = input.ToLower();
                    if (input == "quit")
                    {
                        break;
                    }
                }

            scripture.HideRandomWords(3);
            Console.Clear();
        }
        Console.WriteLine(scripture.GetCompletelyHiddenText());
       
    }
}
