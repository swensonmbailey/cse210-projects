public class Activity
{
    private string _name;
    private string _description;
    private int _seconds;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void SetUpActivity()
    {

        Console.Clear();

        DisplayStartMessage();

        DisplayDescription();

        Console.Write("How long (in seconds) would you like to do this activity? ");
        int seconds;
        while (!int.TryParse(Console.ReadLine(), out seconds))
        {
            Console.Write("Please Enter Seconds as an integer: ");
        }
        SetSeconds(seconds);

        Console.Clear();

        Console.WriteLine($"{_name} Activity is about to begin... ");
        DisplaySpinner(3);
    }


    protected void DisplayDescription()
    {
        Console.WriteLine($"{_description}\n");
    }

    protected void CountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            if (i >= 10)
            {
                Console.Write("\b \b\b \b");
            }
            else
            {
                Console.Write("\b \b");
            }

        }
    }

    protected void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity\n");
    }

    protected void DisplayEndMessage()
    {
        Console.Clear();
        Console.WriteLine($"You have successfully completed the {_name} Activity. It only took you {_seconds} seconds.");
    }

    protected void DisplaySpinner(int seconds)
    {
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int index = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index]);
            index = (index == (spinner.Count - 1)) ? 0 : index + 1;
            System.Threading.Thread.Sleep(300);
            Console.Write("\b \b");
            // if (index == (spinner.Count - 1))
            // {
            //     index = 0;
            // }
            // else
            // {
            //     index++;
            // }
        }
    }

    protected string GetName()
    {
        return _name;
    }

    protected int GetSeconds()
    {
        return _seconds;
    }

    private void SetSeconds(int seconds)
    {
        _seconds = seconds;   
    }
}