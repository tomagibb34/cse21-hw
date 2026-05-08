using System;
using static Job;
using static Resume;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        // Create a new resume
        Resume myResume = new Resume();
        
        // Set the name of the resume
        myResume._name = "John Doe";

        // Create a new job experience
        Job job1 = new Job();

        // Set the job details
        job1._jobTitle = "Software Engineer";
        job1._company = "Tech Company";
        job1._startYear = 2020;
        job1._endYear = 2022;

        // Add the job experience to the resume
        myResume._jobs.Add(job1);

        // Create another job experience
        Job job2 = new Job();
        // Set the job details
        job2._jobTitle = "Senior Software Engineer";
        job2._company = "Another Tech Company";
        job2._startYear = 2022;
        job2._endYear = 2024;

        // Add the second job experience to the resume
        myResume._jobs.Add(job2);

        // Display the resume

        myResume.Display();

    }
}