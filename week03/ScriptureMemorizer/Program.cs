using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

// Class to represent a scripture reference (e.g., John 3:16 or Proverbs 3:5-6)
class Reference
{
    public string Book { get; }
    public int Chapter { get; }
    public int StartVerse { get; }
    public int? EndVerse { get; } // Nullable for single verses

    public Reference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        return EndVerse.HasValue ? $"{Book} {Chapter}:{StartVerse}-{EndVerse}" : $"{Book} {Chapter}:{StartVerse}";
    }
}

// Class to represent an individual word in the scripture
class Word
{
    public string Text { get; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide() => IsHidden = true;

    public override string ToString() => IsHidden ? new string('_', Text.Length) : Text;
}

// Class to manage the scripture text and hiding logic
class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        var visibleWords = _words.Where(w => !w.IsHidden).ToList();
        if (visibleWords.Count == 0) return;

        int wordsToHide = Math.Min(count, visibleWords.Count);
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool IsFullyHidden() => _words.All(w => w.IsHidden);

    public override string ToString() => $"{_reference}\n{string.Join(" ", _words)}";
}

// Main program class to run the scripture memorizer
class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer!\n");
        
        // Example scriptures (You can load from a file as an enhancement)
        var scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me.")
        };
        
        // Pick a random scripture
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];
        
        while (!scripture.IsFullyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress ENTER to hide words or type 'quit' to exit.");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit") break;

            scripture.HideRandomWords(3); // Hide 3 words per turn
        }

        Console.Clear();
        Console.WriteLine(scripture);
        Console.WriteLine("\nWell done! You have fully memorized the scripture.");
    }
}
