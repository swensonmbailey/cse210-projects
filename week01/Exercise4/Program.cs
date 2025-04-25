using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>();
        int num = 1;

        Console.WriteLine("Enter a series of number (type 0 to stop): ");
        while(num != 0){
            num = int.Parse(Console.ReadLine());
            if (num != 0){
                nums.Add(num);
            }
        }

        int sum = nums.Sum();
        double average = nums.Average();
        int max = nums.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The max is: {max}");
    }
}