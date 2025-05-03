[Serializable]
public class Person
{
    public string _firstName {get; set;} = "";
    
    public string _lastName {get; set;} = "";

    public int _currentAge {get; set;} = 0;

    public string GetFullName()
    {
        return $"{_firstName} {_lastName}";
    }

    public void InputPersonalData()
    {
        Console.Write("\nEnter you first name: ");
        _firstName = Console.ReadLine();

        Console.Write("Enter you last name: ");
        _lastName = Console.ReadLine();

        Console.Write("What is your current age: ");
        _currentAge = Int32.Parse(Console.ReadLine());
    }
}