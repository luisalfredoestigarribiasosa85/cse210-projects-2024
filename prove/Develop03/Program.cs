using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        string verseText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        Scripture scripture = new Scripture(reference, verseText);

        int attempts = 0;
        Console.Write("Enter the number of attempts as goal: ");
        int maxAttempts = int.Parse(Console.ReadLine());

        bool continueHiding = true;

        // Exceeding core requirements
        // This adds a competitive component, making the user try to memorize the passage with fewer attempts or in less time.
        while (continueHiding && !scripture.IsCompletelyHidden() && attempts < maxAttempts)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine($"\nAttempt {attempts + 1}/{maxAttempts}");
            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                continueHiding = false;
            }
            else
            {
                scripture.HideRandomWords(2);
                attempts++;
            }
        }

        if (attempts >= maxAttempts)
        {
            Console.WriteLine("\nYou have reached the maximum number of attempts. The program will end.");
        }
        else if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nAll words are hidden. Program will now exit.");
        }
    }
}
