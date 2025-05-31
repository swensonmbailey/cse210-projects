public abstract class Goal
{
    protected string _name;
    protected string _description;

    public Goal(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public abstract int CompleteTask();

    public abstract void DisplayGoal(int index = -1);

    public abstract string SaveGoal();
}