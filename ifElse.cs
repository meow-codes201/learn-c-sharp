
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       
       Console.Write("Enter your age : ");
       int age = Convert.ToInt32(Console.ReadLine());
       if(age >= 18){
           Console.WriteLine("Voting allowed");
       }
       else{
           Console.WriteLine("Voting not allowed");
       }
       
    }
}
