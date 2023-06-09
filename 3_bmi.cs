using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double bmi, w, h;

        Console.WriteLine("Podaj wagę (w kg): ");
        w = inputValue();
        Console.WriteLine("Podaj wzrost (w m) : ");
        h = inputValue();
        bmi = w / Math.Pow(h, 2);
        Console.WriteLine("BMI wynosi: " + bmi);
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
