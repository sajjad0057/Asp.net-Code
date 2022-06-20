using System;


public class Program
{
    public static void Main(string[] args)
    {
        int Recursion(int x)
        {
            if (x <= 1)
                return 1;
            else 
                return x * Recursion(x - 1);
        }

        Console.WriteLine(Recursion(3));
    }
}
