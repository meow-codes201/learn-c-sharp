
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Math class");
        double x = 9;
        double power = Math.Pow(x,2);
        Console.WriteLine(power);
        double root = Math.Sqrt(power);
        Console.WriteLine(root);
        double abslt = Math.Abs(-x);
        Console.WriteLine(abslt);
        double r = 9.5;
        double rounded = Math.Round(r);
        Console.WriteLine(rounded);
        double ceiled = Math.Ceiling(r);
        Console.WriteLine(ceiled);
        double floored = Math.Floor(r);
        Console.WriteLine(floored);
        double maxxing = Math.Max(x,r);
        Console.WriteLine(maxxing);
        double minning = Math.Min(x,r);
        Console.WriteLine(minning);
        
    }
}
