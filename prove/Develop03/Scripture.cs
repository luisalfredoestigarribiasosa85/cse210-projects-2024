using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        int visibleWordsCount = GetVisibleWordsCount();

        if (visibleWordsCount == 0)
        {
            return;
        }

        while (hiddenCount < numberToHide && visibleWordsCount > 0)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
                visibleWordsCount--;
            }
        }
    }

    private int GetVisibleWordsCount()
    {
        int count = 0;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                count++;
            }
        }
        return count;
    }

    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()} ";
        foreach (Word word in _words)
        {
            displayText += $"{word.GetDisplayText()} ";
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
