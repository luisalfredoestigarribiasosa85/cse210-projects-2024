using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _duration;
    public List<Comment> _comments;

    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
        _comments = new List<Comment>();
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title} | Author: {_author} | Duration: {_duration} seconds");
    }

    public void NumberOfComments()
    {
        Console.WriteLine($"Number of comments: {_comments.Count}");
    }

    public void ListComments()
    {
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }

    public void AddComment(string name, string text)
    {
        _comments.Add(new Comment(name, text));
    }
}