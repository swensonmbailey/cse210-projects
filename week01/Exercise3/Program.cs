using System;

class Program
{
    static void Main(string[] args)
    {
        Random ranGen = new Random();
        int magicNum = ranGen.Next(1, 101);
        int guess;

        bool keepGuessing = true;
        while(keepGuessing){
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if(guess > magicNum){
                Console.WriteLine("Higher");
            } else if (guess < magicNum){
                Console.WriteLine("Lower");
            } else {
                Console.WriteLine("You guessed it!");
                keepGuessing = false;
            }
        }
    }
}