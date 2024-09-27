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
        Console.WriteLine($"{_date.ToShortDateString()} {_promptText} {_entryText}");
    }
}