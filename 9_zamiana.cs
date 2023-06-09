using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;

        Console.WriteLine("Podaj 3 liczby:");
        a = inputValue();
        b = inputValue();
        c = inputValue();
        a = a + b;
        b = b - a;
        a = a + b;
        b = b * -1;
        a = a + c;
        c = c - a;
        a = a + c;
        c = c * -1;
        Console.WriteLine("Wartości liczb po zamianie miejsc: a: " + a + ", b: " + b + ", c: " + c);
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
