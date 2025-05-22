public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> {"Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"};
    private List<string> _items = new List<string>();

    public ListingActivity() : base("Listing",
    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    public void RunActivity()
    {
        Console.Clear();

        string randPrompt = GetRandomPrompt();


        Console.WriteLine("Your Prompt: ");
        Console.WriteLine($"{randPrompt}");
        Console.Write("Reflect on this prompt...");
        DisplaySpinner(5);

        Console.Clear();
        Console.WriteLine("Your Prompt: ");
        Console.WriteLine($"{randPrompt}");
        Console.WriteLine("Keep entering responses until the time runs out: ");


        Console.WriteLine("");
        DateTime endTime = DateTime.Now.AddSeconds(GetSeconds() - 5);
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            _items.Add(Console.ReadLine());
        }

        DisplayEndMessage();
        Console.WriteLine($"You entered {_items.Count} responses!");
    }
    
    private string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(0, _prompts.Count);

        return _prompts[index];
    }
}
