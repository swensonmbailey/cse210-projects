public class Comment
{
    public string _user;
    public string _text;

    public void DisplayComment()
    {
        Console.WriteLine($"{_user}: {_text}");
    }
}