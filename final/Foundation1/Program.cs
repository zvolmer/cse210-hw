using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Intro to C#", "Larry", 300);
        v1.AddComment(new Comment("Bob", "Great tutorial!"));
        v1.AddComment(new Comment("Carol", "Very helpful."));
        v1.AddComment(new Comment("Dave", "Thanks for this."));
        videos.Add(v1);

        Video v2 = new Video("Abstraction Basics", "Stephanie", 450);
        v2.AddComment(new Comment("Frank", "Clear explanation."));
        v2.AddComment(new Comment("Grace", "Loved the examples."));
        v2.AddComment(new Comment("Kevin", "Can you cover more?"));
        videos.Add(v2);

        Video v3 = new Video("Using Abstraction in C#", "Gary", 200);
        v3.AddComment(new Comment("Judy", "Exactly what I needed."));
        v3.AddComment(new Comment("Susan", "Nicely done."));
        v3.AddComment(new Comment("Steven", "Please do advanced next."));
        videos.Add(v3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length (sec): " + video.LengthSec);
            Console.WriteLine("Number of comments: " + video.GetCommentCount());
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.Author + ": " + comment.Text);
            }
            Console.WriteLine();
        }
    }
}
