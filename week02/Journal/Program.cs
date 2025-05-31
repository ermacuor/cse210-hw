using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        while (true)
        {
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();
            if (option == "1")
            {
                Entry newEntry = new Entry();
                string prompttext = promptGenerator.GetRandomPrompt();
                newEntry._date = dateText;
                Console.WriteLine($">{prompttext} ");
                newEntry._prompText = prompttext;
                Console.Write(">> ");
                newEntry._entryText = Console.ReadLine();
                myJournal.AddEntry(newEntry);
            }
            else if (option == "2")
            {
                myJournal.DisplayAll();
            }
            else if (option == "3")
            {
                Console.WriteLine("What is te filename?");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
            else if (option == "4")
            {
                Console.WriteLine("What is te filename?");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
            else if (option == "5")
            {
                Console.WriteLine("leaving the journal");
                return;
            }
            else
            {
                Console.WriteLine("invalid, try again");
                Console.ReadLine();

            }
        }    
    }
}