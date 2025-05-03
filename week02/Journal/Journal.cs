//
using System.Buffers;
using System.Text.Json.Serialization;
[Serializable]
public class Journal
{
    public List<String> _prompts = new List<string> {"If I could have dinner with any fictional character, who would it be and why?", 
    "What would I do if I woke up with a superpower tomorrow?",
    "Design my dream vacation—no budget, no limits.",
    "If my life were a movie, what would the title be? Explain.",
    "What’s the weirdest dream I’ve ever had?",
    "What would my alter ego be like?",
    "What’s a silly talent I wish I had?",
    "If animals could talk, which would be the sassiest and why?",
    "Describe my perfect lazy Sunday.",
    "Write a journal entry from the perspective of my pet (or imaginary pet).",
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"};

    public List<Entry> _entries {get; set;} = new List<Entry>();

    public Person _owner {get; set;} = new Person();

    public void CreateNewEntry()
    {
        Entry newEntry = new Entry()
        {
            _date = DateTime.Now.ToString(),

            _age = _owner._currentAge,

            _prompt = getPrompt()
        };
        
        Console.WriteLine($"{newEntry._prompt}");

        newEntry._response = Console.ReadLine();

        _entries.Add(newEntry);
    }

    public string getPrompt()
    {
        
        Random rnd = new Random();
        string input;
        string selectedPrompt = "";

        while(true)
        {
            int rndIndex = rnd.Next(0, _prompts.Count);
            selectedPrompt = _prompts[rndIndex];

            Console.WriteLine($"Would you like to respond to this journal prompt?: {selectedPrompt}");
            
            Console.Write("(Y/N?): ");

            do{

                input = Console.ReadLine().ToLower();

            }while(input != "y" && input != "n");
            

            if(input == "y" )
            {
                break;
            }

        }

        return selectedPrompt;
    }

    public void DisplayJournal()
    {
        foreach(var entry in _entries)
        {
            entry.DisplayEntry();
        }
    }



}