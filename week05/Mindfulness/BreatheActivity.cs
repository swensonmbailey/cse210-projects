public class BreatheActivity : Activity
{
    public BreatheActivity() : base("Breate",
    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public void RunActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(GetSeconds());

        bool breathIn = true;

        while (DateTime.Now < endTime)
        {
            Console.Clear();

            if (breathIn)
            {
                Breate("in");
            }
            else
            {
                Breate("out");
            }

            breathIn = !breathIn;
        }

        DisplayEndMessage();
    }

    private void Breate(string inOrOut)
    {
        Console.Write($"Breathe {inOrOut}...");
        CountDown(5);
        Console.WriteLine();
    }
    
    
}