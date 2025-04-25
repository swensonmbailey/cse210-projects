using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grad percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        string letter;
        bool passed = false;

        if (gradePercentage >= 90){
            letter = "A";
            passed = true;
        } else if (gradePercentage >= 80) {
            letter = "B";
            passed = true;
        } else if (gradePercentage >= 70) {
            letter = "C";
            passed = true;
        } else if (gradePercentage >= 60) {
            letter = "D";
        } else {
            letter = "F";
        }   
        
        Console.WriteLine($"Your letter grade for this course: {letter}");

        if (passed){
            Console.WriteLine("Congrats! You passed this course.");
        } else{
            Console.WriteLine("You did not pass this course. You may take it again. Better luck next time.");
        }

    }
}