using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date.ToShortDateString()}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        try
        {
            using (StreamReader reader = new StreamReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        DateTime date = DateTime.Parse(parts[0]);
                        string prompt = parts[1];
                        string text = parts[2];
                        _entries.Add(new Entry(date, prompt, text));
                    }
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. No entries loaded.");
        }
    }
}