using System.Runtime.InteropServices;
using System.Security.AccessControl;

public class Video
{
    public List<Comment> _comments = new List<Comment>();
    public int _length;
    public string _title;
    public String _author;

    public void ConvertToSec(string time)
    {
        int indexFistColon = time.IndexOf(":");
        int indexSecondColon = time.IndexOf(":", indexFistColon + 1);

        int hours = int.Parse(time.Substring(0, indexFistColon));
        int minutes = int.Parse(time.Substring(indexFistColon+1, indexSecondColon-indexFistColon-1));
        int sec = int.Parse(time.Substring(indexSecondColon+1));

        int totalSec = (hours * 60 * 60) + (minutes * 60) + sec;
        _length = totalSec;
    }

    public int CountComments()
    {
        return _comments.Count;
    } 

    public void CreateComment(string user, string text)
    {
        Comment comment = new Comment();
        comment._user = user;
        comment._text = text;
        _comments.Add(comment);
    }
    
    public void DisplayComments()
    {
        Console.WriteLine($"Comments: ");
        foreach (var comment in _comments)
        {
            comment.DisplayComment();
        }
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"By: {_author}");
        Console.WriteLine($"Length: {_length}Secs");
        Console.WriteLine($"{CountComments()} Comments");

        DisplayComments();
        Console.WriteLine("");
    }
}