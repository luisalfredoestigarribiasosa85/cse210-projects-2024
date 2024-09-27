using System;

public class Entry
{
    public DateTime _date;
    public string _promptText;
    public string _entryText;

    public Entry(DateTime date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date.ToShortDateString()}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }
}