using System.IO.Compression;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>{"Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless." };
    private List<string> _questions = new List<string>{"Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?" };

    public ReflectionActivity() : base("Relection",
    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
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

        Random rnd = new Random();
        int index = rnd.Next(0, _prompts.Count);

        DateTime endTime = DateTime.Now.AddSeconds(GetSeconds() - 5);
        while (DateTime.Now < endTime)
        {
            Console.Clear();

            Console.WriteLine("Your Prompt: ");
            Console.WriteLine($"{randPrompt}");
            Console.WriteLine();

            Console.WriteLine($"Ask your self... {_questions[index]}");
            DisplaySpinner(10);

            index = (index == (_questions.Count - 1)) ? 0 : index + 1;

        }

        DisplayEndMessage();

    }

    private string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(0, _prompts.Count);

        return _prompts[index];
    }
    

}   