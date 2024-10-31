using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(
            new DateTime(2024, 10, 30),
            30,
            3.0));

        activities.Add(new Cycling(
            new DateTime(2024, 10, 30),
            45,
            15.0));

        activities.Add(new Swimming(
            new DateTime(2024, 10, 30),
            20,
            10));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}