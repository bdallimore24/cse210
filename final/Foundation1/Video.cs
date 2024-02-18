using System;
using System.Collections.Generic;

class Video
{

    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comment;

    public Video(string title, string author, int length)
    {

        _title = title;
        _author = author;
        _length = length;
        _comment = new List<Comment>();

    }

    public void AddComment(Comment comment)
    {

        _comment.Add(comment);

    }

    public int GetNumberofComments()
    {

        return _comment.Count;

    }

    public List<Comment> GetComments()
    {

        return _comment;

    }
}