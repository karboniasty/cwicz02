using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;

        Console.WriteLine("Podaj 3 liczby: ");
        a = inputValue();
        b = inputValue();
        c = inputValue();
        if (a == b && b == c)
        {
            Console.WriteLine("Z tych liczb można utworzyć trójkąt równoboczny");
        }
        else
        {
            Console.WriteLine("Z tych liczb nie można utworzyć trójkąta równobocznego");
        }
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
