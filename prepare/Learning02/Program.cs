using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._companyName = "THN";
        job1._jobTitle = "Driver";
        job1._startYear = 2023;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._companyName = "The embassy of Qatar";
        job2._jobTitle = "Diplomatic Driver";
        job2._startYear = 2024;
        job2._endYear = 2024;

        Resume resume = new Resume();
        resume._name = "Luis Estigarribia";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResume();
    }
}