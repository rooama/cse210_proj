using System;

class Program
{
    static void Main()
    {
        // Create job instances
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Create resume instance
        Resume myResume = new Resume();
        myResume._personName = "John Doe";
        myResume._jobs.Add(job1); // Adding job1 to the resume
        myResume._jobs.Add(job2); // Adding job2 to the resume

        // Display the full resume
        myResume.Display();
    }
}
