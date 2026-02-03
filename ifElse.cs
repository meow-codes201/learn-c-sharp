
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
       else if(age<0){
           Console.WriteLine("You're not born yet");
       }
       else{
           Console.WriteLine("not allowed");
       }
       
    }
}
