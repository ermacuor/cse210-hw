using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        if (newEntry._entryText == "")
        {
            Console.WriteLine("The answer is empty.");
            return;
        }
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The Journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string filename)
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The Journal is empty.");
            return;
        }
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"Date: { entry._date}|Prompt: {entry._prompText}|Enry: {entry._entryText}");
                
            }
        }


    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                Entry newEntry = new Entry();
                string[] parts = line.Split('|');

                
                if (parts.Length == 3)
                {
                    newEntry._date = parts[0];
                    newEntry._prompText = parts[1];
                    newEntry._entryText = parts[2];
                    _entries.Add(newEntry);
                }
            }
            Console.WriteLine("Diario cargado correctamente.");
        }
        else
        {
            Console.WriteLine("El archivo no existe.");
        }

    }
}