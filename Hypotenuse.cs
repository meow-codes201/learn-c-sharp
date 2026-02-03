
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       //Find hypotenuse of a right triangle
       Console.Write("Enter base ");
       double b = Convert.ToDouble(Console.ReadLine());
       Console.Write("Enter Height ");
       double h = Convert.ToDouble(Console.ReadLine());
       double hp = Math.Sqrt((Math.Pow(b,2)+Math.Pow(h,2)));
       Console.WriteLine("Hypotenuse = "+hp);
        
        
    }
}
