using System;
using System.Collections.Generic;

class Program
{
    private List<Video> videos;

    public Program()
    {
        videos = new List<Video>();
    }

    public void InitializeVideos()
    {
        Video video1 = new Video("Learning C#", "Juan Pérez", 300);
        video1.Comments.Add(new Comment("María", "Very useful, thank you!"));
        video1.Comments.Add(new Comment("Carlos", "Great explanation!"));
        video1.Comments.Add(new Comment("Erik", "Anyone else binge-watching programming tutorials?"));


        Video video2 = new Video("Design Patterns", "Ana López", 450);
        video2.Comments.Add(new Comment("Luis", "Incredible content!"));
        video2.Comments.Add(new Comment("Mark", "Replaying this because the explanations are GOLD!"));
        video2.Comments.Add(new Comment("Hyrum", "Straight to the point—no unnecessary fluff. I appreciate it!"));

        Video video3 = new Video("Mastering C# Fundamentals: Your First Steps Into Coding!", "Sierra Summers", 480);
        video3.Comments.Add(new Comment("Claudia", "This tutorial is a game-changer! Thanks for making C# so easy to understand."));
        video3.Comments.Add(new Comment("Nathan", "Finally, a class that explains C# in a way that makes sense!"));
        video3.Comments.Add(new Comment("Megan", "I’ve always struggled with programming, but this video is super helpful. Thanks a ton!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
    }

    public void DisplayVideos()
    {
        foreach (var video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Program program = new Program();
        program.InitializeVideos();
        program.DisplayVideos();
    }
}
