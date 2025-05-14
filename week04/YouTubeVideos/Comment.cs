public class Comment
{
    public string user;
    public string text;

    public void DisplayComment()
    {
        Console.WriteLine($"{user}: {text}");
    }
}