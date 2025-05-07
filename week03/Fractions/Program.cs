using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction(1);
        Fraction frac3 = new Fraction(6,7);

        frac1.SetTop(2);
        frac1.SetBottom(5);

        Console.WriteLine(frac1.GetFractionString() + $" = {frac1.GetDecimalValue()}");
        Console.WriteLine(frac2.GetFractionString() + $" = {frac2.GetDecimalValue()}");
        Console.WriteLine(frac3.GetFractionString() + $" = {frac3.GetDecimalValue()}");


    }
}