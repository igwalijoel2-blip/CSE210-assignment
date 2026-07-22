using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;


    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }


    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }


    public int GetNumberOfComments()
    {
        return _comments.Count;
    }


    public string GetDisplayText()
    {
        string output = "";

        output += $"Title: {_title}\n";
        output += $"Author: {_author}\n";
        output += $"Length: {_length} seconds\n";
        output += $"Number of Comments: {GetNumberOfComments()}\n";

        output += "\nComments:\n";

        foreach (Comment comment in _comments)
        {
            output += $"- {comment.GetDisplayText()}\n";
        }

        return output;
    }
}