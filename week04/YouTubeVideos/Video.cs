using System.Runtime.InteropServices;
using System.Security.AccessControl;

public class Video
{
    public List<Comment> comments = new List<Comment>();
    public int length;
    public string title;
    public String author;

    public void ConvertToSec(string time)
    {
        int indexFistColon = time.IndexOf(":");
        int indexSecondColon = time.IndexOf(":", indexFistColon + 1);

        int hours = int.Parse(time.Substring(0, indexFistColon));
        int minutes = int.Parse(time.Substring(indexFistColon+1, indexSecondColon-indexFistColon-1));
        int sec = int.Parse(time.Substring(indexSecondColon+1));

        int totalSec = (hours * 60 * 60) + (minutes * 60) + sec;
        length = totalSec;
    }

    public int CountComments()
    {
        return comments.Count;
    } 

    public void CreateComment(string user, string text)
    {
        Comment comment = new Comment();
        comment.user = user;
        comment.text = text;
        comments.Add(comment);
    }
    
    public void DisplayComments()
    {
        Console.WriteLine($"Comments: ");
        foreach (var comment in comments)
        {
            comment.DisplayComment();
        }
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"{title}");
        Console.WriteLine($"By: {author}");
        Console.WriteLine($"Length: {length}Secs");
        Console.WriteLine($"{CountComments()} Comments");

        DisplayComments();
        Console.WriteLine("");
    }
}