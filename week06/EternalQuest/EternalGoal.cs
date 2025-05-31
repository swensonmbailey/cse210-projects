public class EternalGoal : Goal
{
    private int _points;

    public EternalGoal(string name, string description, int points) : base(name, description)
    {
        _points = points;
    }

    public override int CompleteTask()
    {
        Console.WriteLine($"\nCongrats! You are keeping your goal! You earned {_points} points.\n");
        return _points;
    }

    public override void DisplayGoal(int index = -1)
    {
        string brackets;
        if (index == -1)
        {
            brackets = "Eternal";
        }
        else
        {
            brackets = $"id: {index.ToString()}";
        }
        Console.WriteLine($"[{brackets}] {_name} : ({_description})");
    }

    public override string SaveGoal()
    {
        return $"EternalGoal,{_name},{_description},{_points}";
    }
}