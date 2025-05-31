using System.Data.Common;
using System.Text;

public class Player
{
    private int _points;
    private int _level;
    private List<Goal> _goals = new List<Goal>();

    public Player(int points = 0, int level = 0)
    {
        _points = points;
        _level = level;
    }

    public void RecordEvent()
    {
        int i = 0;
        foreach (var goal in _goals)
        {
            goal.DisplayGoal(i);
            i++;
        }

        Console.Write($"\nEnter the id of the goal: ");
        int selected;
        while (!int.TryParse(Console.ReadLine(), out selected))
        {
            Console.Write("Invalid. Enter the goal's id:  ");
        }

        AddPoints(_goals[selected].CompleteTask());

        Console.Write("Press enter to return to main menu: ");
        Console.ReadLine();
    }

    private void AddPoints(int points)
    {
        _points += points;
        LevelUp();
    }

    private void LevelUp()
    {
        if ((_points / 500) > _level)
        {
            _level = _points/500;
            Console.WriteLine($"Congrats! You have reached level {_level}.");
        }
    }

    public void DisplayPlayerPoints()
    {
        Console.WriteLine($"You have {_points} points. Your current level is {_level}\n");
    }

    public void DisplayGoalData()
    {
        Console.Clear();
        Console.WriteLine("Your tasks: ");
        foreach (var goal in _goals)
        {
            goal.DisplayGoal();
        }

        Console.Write("Press enter to return to main menu: ");
        Console.ReadLine();
    }

    public void SavePlayerData()
    {
        Console.Clear();
        Console.Write($"Enter the name of the file where you want to save your data (include the extention '.csv'): ");
        String file = Console.ReadLine();

        StringBuilder saveContent = new StringBuilder();
        saveContent.AppendLine($"{_points},{_level}");

        foreach (var goal in _goals)
        {
            saveContent.AppendLine(goal.SaveGoal());
        }

        File.WriteAllText(file, saveContent.ToString());

        Console.WriteLine($"Data saved to '{file}'");
        Console.Write("Press Enter to return to menu: ");
        Console.ReadLine();
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void LoadPlayerData()
    {
        Console.Clear();
        Console.Write($"Enter the name of the file you want to load(include the extention '.csv'): ");
        String file = Console.ReadLine();

        if (File.Exists(file))
        {
            string[] loadData = File.ReadAllLines(file);

            int i = 0;
            foreach (var line in loadData)
            {
                string[] goalData = line.Split(',');

                if (i == 0)
                {
                    //load points and level
                    _points = int.Parse(goalData[0]);
                    _level = int.Parse(goalData[1]);
                    i++;
                    continue;
                }

                switch (goalData[0])
                {
                    case "SimpleGoal":
                        LoadSimpleGoal(goalData);
                        break;
                    case "EternalGoal":
                        LoadEternalGoal(goalData);
                        break;
                    case "CheckListGoal":
                        LoadChecklistGoal(goalData);
                        break;
                    default:
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine($"{file} does not exist");
        }



        Console.Write("Enter anything to return to Menu: ");
        Console.ReadLine();
    }
    private void LoadSimpleGoal(string[] loadData)
    {
        SimpleGoal goal = new SimpleGoal(loadData[1], loadData[2], int.Parse(loadData[3]), bool.Parse(loadData[4]));
        _goals.Add(goal);
    }

    private void LoadEternalGoal(string[] loadData)
    {
        EternalGoal goal = new EternalGoal(loadData[1], loadData[2], int.Parse(loadData[3]));
        _goals.Add(goal);
    }

    private void LoadChecklistGoal(string[] loadData)
    {
        ChecklistGoal goal = new ChecklistGoal(loadData[1], loadData[2], int.Parse(loadData[3]), int.Parse(loadData[4]), int.Parse(loadData[5]), int.Parse(loadData[6]), bool.Parse(loadData[7]));
        _goals.Add(goal);
    }
}