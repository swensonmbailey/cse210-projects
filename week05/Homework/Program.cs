using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment("Samuel Bennett", "Multiplication", "7.3", "8-19");
        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
        
    }
}