
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Arithmetic operations");
        int pizza = 2;
        //add
        pizza = pizza+4;
        Console.WriteLine(pizza);
        pizza++;
        Console.WriteLine(pizza);
        pizza += 2;
        Console.WriteLine(pizza);
        
        //sub
        pizza = pizza -2;
        Console.WriteLine(pizza);
        pizza--;
        Console.WriteLine(pizza);
        pizza -= 4;
        Console.WriteLine(pizza);
        
        //mul
        pizza = pizza * 2;
        Console.WriteLine(pizza);
        pizza *= 2;
        Console.WriteLine(pizza);
        
        //div
        pizza = pizza/2;
        Console.WriteLine(pizza);
        pizza /=2;
        Console.WriteLine(pizza);
        
        //modulo
        pizza = pizza%2;
        Console.WriteLine(pizza);
        pizza = 2;
        pizza %= 2;
        Console.WriteLine(pizza);
        Console.WriteLine("THAT WAS TASTY");
    }
}
