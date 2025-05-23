public class Session
{
    private bool _breatheComplete = false;
    private bool _reflectionComplete = false;
    private bool _listingComplete = false;
    private int _seconds = 0;

    public void SetCompleted(string activity)
    {
        switch (activity)
        {
            case "breathe":
                _breatheComplete = true;
                break;
            case "reflection":
                _reflectionComplete = true;
                break;
            case "listing":
                _listingComplete = true;
                break;
        }
    }

    public void AddTime(int seconds)
    {
        _seconds += seconds;
    }

    private void DisplayTotalTime()
    {
        Console.WriteLine($"Your current session has only taken you {_seconds / 60} minutes & {_seconds % 60} seconds.");
    }

    private void CheckAllCompleted()
    {
        if (_breatheComplete && _listingComplete && _reflectionComplete)
        {
            Console.WriteLine("Congrats! You have performed a complete session:\n-Breathe: completed\n-Reflection: completed\n-Listing: completed");
        }
        else
        {
            string breathe = _breatheComplete ? "completed" : "not completed";
            string reflection = _reflectionComplete ? "completed" : "not completed";
            string listing = _listingComplete ? "completed" : "not completed";
            Console.WriteLine($"Keep going! Not quite a complete session:\n-Breathe: {breathe}\n-Reflection: {reflection}\n-Listing: {listing}");
        }
    }

    public void DisplaySession()
    {
        CheckAllCompleted();
        DisplayTotalTime();
    }

}