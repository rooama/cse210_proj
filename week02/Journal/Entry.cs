using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    // Constructor
    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    // Display the entry
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine("---------------------------------");
    }

    // Convert to a string format for saving
    public string FormatForFile()
    {
        return $"{_date}~|~{_prompt}~|~{_response}";
    }

    // Create an entry from a file line
    public static Entry ParseFromFile(string line)
    {
        string[] parts = line.Split("~|~");
        return new Entry(parts[0], parts[1], parts[2]);
    }
}
