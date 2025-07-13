using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int LengthSec { get; private set; }
    private List<Comment> comments;

    public Video(string title, string author, int lengthSec)
    {
        this.Title = title;
        this.Author = author;
        this.LengthSec = lengthSec;
        this.comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        this.comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return this.comments.Count;
    }

    public List<Comment> GetComments()
    {
        return new List<Comment>(this.comments);
    }
}
