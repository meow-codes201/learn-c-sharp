
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       //string methods
       String name = "Teddy Bear";
       String upIt = name.ToUpper();
       Console.WriteLine(upIt);
       String lowIt = name.ToLower();
       Console.WriteLine(lowIt);
       String firstName = name.Substring(0,5);
       Console.WriteLine(firstName);
       String lastName = name.Substring(6,4);
       Console.WriteLine(lastName);
       String ph = "987-654-3210";
       ph = ph.Replace("-"," ");
       Console.WriteLine(ph);
       ph = ph.Insert(0,"My number : ");
       Console.WriteLine(ph);
       Console.WriteLine(ph.Length);
       
       
       
       
       
       
       
    }
}
