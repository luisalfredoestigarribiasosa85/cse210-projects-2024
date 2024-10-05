using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        string verseText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        Scripture scripture = new Scripture(reference, verseText);

        bool continueHiding = true;

        while (continueHiding)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (!scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    continueHiding = false;
                }
                else
                {
                    Random randomNumber = new Random();
                    scripture.HideRandomWords(randomNumber.Next(4));
                }
            }
            else
            {
                Console.Clear();
                continueHiding = false;
            }
        }
    }
}
