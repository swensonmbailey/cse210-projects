using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {

        Session session = new Session();
        bool breakOuter = false;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Mindfulness, where your mind is Key\n");

            Console.WriteLine($"Menu:   \n1: Breathe Activity\n2: Reflection Activity\n3: Listing Actitivy\n4: Session Data\n5: Exit");
            Console.Write("Select menu option: ");
            int selected;
            while (!int.TryParse(Console.ReadLine(), out selected))
            {
                Console.Write("Invalid. Select menu option number:  ");
            }

            switch (selected)
            {
                case 1:

                    BreatheActivity breathe = new BreatheActivity();

                    breathe.SetUpActivity();
                    breathe.RunActivity();
                    session.AddTime(breathe.GetSeconds());
                    session.SetCompleted("breathe");

                    Console.Write("Enter anything to return to Menu: ");
                    Console.ReadLine();

                    break;

                case 2:

                    ReflectionActivity reflection = new ReflectionActivity();

                    reflection.SetUpActivity();
                    reflection.RunActivity();
                    session.AddTime(reflection.GetSeconds());
                    session.SetCompleted("reflection");

                    Console.Write("Enter anything to return to Menu: ");
                    Console.ReadLine();

                    break;

                case 3:

                    ListingActivity listing = new ListingActivity();

                    listing.SetUpActivity();
                    listing.RunActivity();
                    session.AddTime(listing.GetSeconds());
                    session.SetCompleted("listing");

                    Console.Write("Enter anything to return to Menu: ");
                    Console.ReadLine();

                    break;

                case 4:

                    Console.WriteLine("Session Data: ");
                    session.DisplaySession();

                    Console.Write("Enter anything to return to Menu: ");
                    Console.ReadLine();

                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("Thank you for being Mindfull of your mind! Good-bye!");
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