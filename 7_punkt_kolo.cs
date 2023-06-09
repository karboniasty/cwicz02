using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double x, y, r;

        Console.WriteLine("Podaj promień koła: ");
        r = (double)inputValue();
        Console.WriteLine("Podaj współrzędne punktu P: ");
        x = (double)inputValue();
        y = (double)inputValue();
        if (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(r, 2))
        {
            Console.WriteLine("Punkt P leży w obrębie koła");
        }
        else
        {
            Console.WriteLine("Punkt P nie leży w obrębie koła");
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
