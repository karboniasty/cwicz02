using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, cyfra;

        Console.WriteLine("Podaj liczbę:");
        a = (int)inputValue();
        cyfra = a / 10;
        cyfra = a - cyfra * 10;
        Console.WriteLine("Ostatnia cyfra tej liczby wynosi: " + cyfra);
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
