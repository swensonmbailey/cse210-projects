public class ChecklistGoal : Goal
{
    private int _partialPoints;
    private int _completedBonus;
    private int _numberOfTasks;
    private int _numberOfCompletedTasks;
    private bool _isComplete;

    public ChecklistGoal(string name, string description, int partialPoints, int completedBonus, int numberOfTasks, int numberOfCompletedTasks = 0, bool isComplete = false) : base(name, description)
    {
        _partialPoints = partialPoints;
        _completedBonus = completedBonus;
        _numberOfTasks = numberOfTasks;
        _numberOfCompletedTasks = numberOfCompletedTasks;
        _isComplete = isComplete;
    }

    public override int CompleteTask()
    {

        if (_isComplete)
        {
            Console.WriteLine("You've already completed this goal.");
            return 0;
        }

        _numberOfCompletedTasks++;
        CheckIfCompleted();

        if (_isComplete)
        {
            Console.WriteLine($"\nCongrats you completed all {_numberOfTasks} tasks and thus your goal! You earned a {_completedBonus} bonus.\n");
            return _completedBonus;
        }
        else
        {
            Console.WriteLine($"\nCongrats! You completed {_numberOfCompletedTasks} of {_numberOfTasks} tasks. You earned {_partialPoints} points.\n");
            return _partialPoints;
        }
        
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
        
        string numCompleted = (_isComplete) ? "" : $"-- Currently complete: {_numberOfCompletedTasks}/{_numberOfTasks}";
        Console.WriteLine($"[{brackets}] {_name} : ({_description}) {numCompleted}");
    }

    public override string SaveGoal()
    {
        return $"CheckListGoal,{_name},{_description},{_partialPoints},{_completedBonus},{_numberOfTasks},{_numberOfCompletedTasks},{_isComplete}";
    }

    private void CheckIfCompleted()
    {
        if (_numberOfCompletedTasks >= _numberOfTasks)
        {
            _isComplete = true;
        }
    }
}