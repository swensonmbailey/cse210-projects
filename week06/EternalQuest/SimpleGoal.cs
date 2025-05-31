public class SimpleGoal : Goal
{
    private int _totalPoints;
    private bool _isComplete;

    public SimpleGoal(string name, string description, int totalPoints, bool isComplete = false) : base(name, description)
    {
        _totalPoints = totalPoints;
        _isComplete = isComplete;
    }

    public override int CompleteTask()
    {
        if (_isComplete)
        {
            Console.WriteLine("You've already completed this goal.");
            return 0;
        }

        _isComplete = true;
        Console.WriteLine($"\nCongrats you completed your goal! You earned {_totalPoints} points.\n");
        return _totalPoints;
    }

    public override void DisplayGoal(int index = -1)
    {

        if (index != -1 && _isComplete)
        {
            return;
        }

        string brackets;
        if (index == -1)
        {
            brackets = (_isComplete) ? "x" : " ";
        }
        else
        {
            brackets = $"id: {index.ToString()}";
        }

        Console.WriteLine($"[{brackets}] {_name} : ({_description})");
    }

    public override string SaveGoal()
    {
        return $"SimpleGoal,{_name},{_description},{_totalPoints},{_isComplete}";
    }

}