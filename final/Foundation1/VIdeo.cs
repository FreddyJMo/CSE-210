using System;

public class Video
{
    public string _title, _author;
    public int _duration;
    public List<Comment> _commentsList = new List<Comment>();

    public void DisplayDetails()
    {
        Console.WriteLine($"\n 1. Video Details\n- Title: {_title}\n- Author: {_author}\n- Duration: {_duration} seconds\n- Comments: {ComputeNumberOfComments()}");
    }

    public void DisplayComments()
    {
        Console.Write("\n 2. Comments: ");

        foreach (Comment comment in _commentsList)
        {
            comment.DisplayComment();
        }
    }
    public int ComputeNumberOfComments()
    {
        return _commentsList.Count();
    }

}