[Serializable]
public class Entry
{
    public string _prompt {get; set;} = "";

    public string _response {get; set;} = "";

    public string _date {get; set;} = "";

    public int _age {get; set;} = 0;

    public void DisplayEntry()
    {
        Console.WriteLine($"\n{_date} Age: {_age}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"{_response} \n");
        
    }
}