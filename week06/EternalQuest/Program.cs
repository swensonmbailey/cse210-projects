using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        bool breakOuter = false;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Eternal Quest!\n");

            player.DisplayPlayerPoints();

            Console.WriteLine($"Menu:   \n1: Create New Goal\n2: List Goals\n3: Save Goals\n4: Load Goals\n5: Record Event\n6: Quit");
            Console.Write("Select menu option #: ");
            int selected;
            while (!int.TryParse(Console.ReadLine(), out selected))
            {
                Console.Write("Invalid. Select menu option number:  ");
            }

            switch (selected)
            {
                case 1:

                    bool stillCreating = true;
                    while (stillCreating)
                    {
                        Console.Clear();
                        Console.WriteLine("Select which type of goal you would like to create.");
                        Console.WriteLine($"1: A Simple Goal\n2: An Eternal Goal\n3: A Checklist Goal\n-1: Back to main menu");

                        while (!int.TryParse(Console.ReadLine(), out selected))
                        {
                            Console.Write("Invalid. Enter the # of the goal you want to create: ");
                        }

                        //create placeholder variables
                        string name;
                        string description;

                        switch (selected)
                        {
                            case 1:
                                Console.Write("What is the name of this goal?: ");
                                name = Console.ReadLine();
                                Console.Write("Please provide a description: ");
                                description = Console.ReadLine();
                                Console.Write("How many total points will you get when completed?: ");
                                int totalPoints = int.Parse(Console.ReadLine());

                                SimpleGoal goal = new SimpleGoal(name, description, totalPoints);
                                player.AddGoal(goal);

                                Console.WriteLine("\nA Simple Goal has been created\n");
                                stillCreating = false;
                                break;
                            case 2:

                                Console.Write("What is the name of this goal?: ");
                                name = Console.ReadLine();
                                Console.Write("Please provide a description: ");
                                description = Console.ReadLine();
                                Console.Write("How many points will you get each time you complete this goal?: ");
                                int points = int.Parse(Console.ReadLine());

                                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                                player.AddGoal(eternalGoal);

                                Console.WriteLine("\nAn Eternal Goal has been created\n");
                                stillCreating = false;
                                break;
                            case 3:

                                Console.Write("What is the name of this goal?: ");
                                name = Console.ReadLine();
                                Console.Write("Please provide a description: ");
                                description = Console.ReadLine();
                                Console.Write("How many tasks do you need to do before this goal is complete?: ");
                                int numberOfTasks = int.Parse(Console.ReadLine());
                                Console.Write("How many points will you get when you complete each partial task?: ");
                                int partialPoints = int.Parse(Console.ReadLine());
                                Console.Write("How many bonus points will you get when you complete the whole goal?: ");
                                int completedBonus = int.Parse(Console.ReadLine());

                                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, partialPoints, completedBonus, numberOfTasks);
                                player.AddGoal(checklistGoal);

                                Console.WriteLine("\nA Checklist Goal has been created\n");
                                stillCreating = false;
                                break;
                            case -1:
                                stillCreating = false;
                                Console.WriteLine("Going back to main menu.");
                                break;
                            default:
                                Console.WriteLine("Invaild number. Please enter a valid number.");
                                break;
                        }

                        Console.Write("Press Enter to continue: ");
                        Console.ReadLine();
                    }

                    break;
                case 2:

                    player.DisplayGoalData();

                    break;

                case 3:

                    player.SavePlayerData();
                    break;

                case 4:

                    player.LoadPlayerData();
                    break;

                case 5:

                    Console.Clear();
                    player.RecordEvent();
                    break;
                case 6:

                    Console.Clear();
                    Console.WriteLine("Thank you for using Eternal Quest! Keep completing your goals.");
                    breakOuter = true;
                    break;
                default:
                    Console.WriteLine("Invalid! Please enter a correct menu number.");
                    Thread.Sleep(2000);
                    break;
            }

            if (breakOuter)
            {
                break;
            }

        }

    }
    
}