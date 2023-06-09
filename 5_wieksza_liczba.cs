using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b;

        Console.WriteLine("Podaj 2 liczby: ");
        a = inputValue();
        b = inputValue();
        if (a > b)
        {
            Console.WriteLine("Wieksza liczba to: " + a);
        }
        Console.WriteLine("Wieksza liczba to: " + b);         
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}

