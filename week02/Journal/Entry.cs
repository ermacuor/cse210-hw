using System;
public class Entry
{
    public string _date;
    public string _prompText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine("-----------------------------");

    }

}