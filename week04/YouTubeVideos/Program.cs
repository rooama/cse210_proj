using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create video objects
        Video video1 = new Video("Sacred Grove", "TechGuru", 600);
        Video video2 = new Video("Faith of Our Fathers", "CodeMaster", 850);
        Video video3 = new Video("Secret Prayer", "DevInsights", 500);

        // Add comments to each video
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "This helped me a lot."));
        video1.AddComment(new Comment("Charlie", "Can you make more videos on C#?"));

        video2.AddComment(new Comment("David", "OOP is finally making sense!"));
        video2.AddComment(new Comment("Eve", "I love how you explained encapsulation."));
        video2.AddComment(new Comment("Frank", "Could you cover more design patterns?"));

        video3.AddComment(new Comment("Grace", "Wow! Debugging made easy!"));
        video3.AddComment(new Comment("Hank", "This saved me hours of frustration."));
        video3.AddComment(new Comment("Ivy", "Clear and concise, thanks!"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video details and comments
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
