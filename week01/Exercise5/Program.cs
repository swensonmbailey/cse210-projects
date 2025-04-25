using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favNum = PromptUserNumber();
        int squareNum = SquareNumber(favNum);
        DisplayResult(name, squareNum);
    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName(){
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        int favNum = int.Parse(Console.ReadLine());
        return favNum;
    }

    static int SquareNumber(int num){
        return num * num;
    }

    static void DisplayResult(string name, int squareNum){
        Console.WriteLine($"{name}, the square of your favorite number is {squareNum}");
    }
}