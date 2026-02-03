
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*typecasting - converting a value of one data type to another data type
                      - utilized while accepting user input(String)
        */
        //double to int
        double a = 9.8;
        int b = Convert.ToInt32(a);
        
        //int to double
        int c = 568;
        double d  = Convert.ToDouble(c) + 0.5;
        //string to int
        String x1 ="1234";
        int x2 = Convert.ToInt32(x1) + 854;
        //string to char
        String symbol = "@";
        char ch = Convert.ToChar(symbol);
        //string to bool
        String isItString = "true";
        bool isItBool = Convert.ToBoolean(isItString);
        Console.WriteLine(b+" - "+b.GetType());
        Console.WriteLine(d+ " - "+ d.GetType());
        Console.WriteLine(x2 + " - "+ x2.GetType());
        Console.WriteLine(ch+" - "+ch.GetType());
        Console.WriteLine(isItBool+" - "+isItBool.GetType());
        
        // Console.ReadKey();
        
    }
}
