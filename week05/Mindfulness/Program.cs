using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        BreatheActivity breathe = new BreatheActivity();

        // breathe.SetUpActivity();
        // breathe.RunActivity();

        ReflectionActivity reflection = new ReflectionActivity();
        // reflection.SetUpActivity();
        // reflection.RunActivity();

        ListingActivity listing = new ListingActivity();
        listing.SetUpActivity();
        listing.RunActivity();
    }
}