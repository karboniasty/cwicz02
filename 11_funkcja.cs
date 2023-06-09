using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double x, y;

        Console.WriteLine("Podaj wartość x:");
        x = inputValue();
        if (x > -2)
        {
            if (x > -1)
            {
                if (x > 1)
                {
                    if (x > 2)
                    {
                        y = 1;
                    }
                    else
                    {
                        y = x - 1;
                    }
                }
                else
                {
                    y = 0;
                }
            }
            else
            {
                y = x + 1;
            }
        }
        else
        {
            y = -1;
        }
        Console.WriteLine("Wartość funkcji w tym punkcie wynosi: " + y);
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
