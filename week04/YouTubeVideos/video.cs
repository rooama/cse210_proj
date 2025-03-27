using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    private List<Comment> Comments { get; set; } // Stores the comments

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>(); // Initializes the comments list
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment); // Adds a comment to the list
    }

    public int GetCommentCount()
    {
        return Comments.Count; // Returns the number of comments
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Video Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");

        foreach (var comment in Comments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }

        Console.WriteLine(); // Blank line for spacing
    }
}
