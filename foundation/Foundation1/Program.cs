using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Abstraction with YouTube Videos");

        Video video = new Video("Funny Cats", "Luis Estigarribia", 300);
        
        video.AddComment("Luis Estigarribia", "My cat and I were watching this video together!!");
        video.AddComment("John Doe", "Nice cats, I love them.");

        video.DisplayInfo();
        video.NumberOfComments();
        video.ListComments();
    }
}