using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables
    public string _personName;
    public List<Job> _jobs = new List<Job>(); // List to store job objects

    // Method to display resume details
    public void Display()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Job History:");
        foreach (Job job in _jobs)
        {
            job.Display(); // Calls Display() from Job class
        }
    }
}
