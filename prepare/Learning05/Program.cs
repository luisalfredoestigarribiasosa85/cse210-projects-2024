using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Luis", "Travel to the center of the earth");

        string showDetails = assignment1.GetSummary();

        Console.WriteLine(showDetails);

        MathAssignment mathAssignment1 = new MathAssignment("Alfredo", "Math in the real world", "5.2", "8-20");
        string showSummary = mathAssignment1.GetSummary();
        string showHomeworkList = mathAssignment1.GetHomeworkList();

        Console.WriteLine(showSummary);
        Console.WriteLine(showHomeworkList);

        WritingAssignment writingAssignment1 = new WritingAssignment("Karina", "World War II", "Helping people after war");
        string showWritingSummary = writingAssignment1.GetSummary();
        string showWritingInfo = writingAssignment1.GetWritingInformation();

        Console.WriteLine(showWritingSummary);
        Console.WriteLine(showWritingInfo);

    }
}