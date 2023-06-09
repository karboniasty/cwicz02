using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, c, d, x, y;

        Console.WriteLine("Podaj 4 liczby całkowite: ");
        a = (int)inputValue();
        b = (int)inputValue();
        c = (int)inputValue();
        d = (int)inputValue();
        if (b * d == 0)
        {
            Console.WriteLine("Brak rozwiązania");
        }
        else
        {
            x = a * d + c * b;
            y = b * d;
            int dzielnik;

            dzielnik = nwd(x, y);
            x = (int)((double)x / dzielnik);
            y = (int)((double)y / dzielnik);
            Console.WriteLine("Licznik ułamka wynosi: " + x);
            Console.WriteLine("Mianownik ułamka wynosi: " + y);
        }
    }

    public static int nwd(int x, int y)
    {
        int r, nwd;

        if (x > y)
        {
        }
        else
        {
            r = x;
            x = y;
            y = r;
        }
        r = x % y;
        while (r != 0)
        {
            x = y;
            y = r;
            r = x % y;
        }
        nwd = y;

        return nwd;
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
