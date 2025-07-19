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
        Title = title;
        Author = author;
        LengthSec = lengthSec;
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return new List<Comment>(comments);
    }
}
