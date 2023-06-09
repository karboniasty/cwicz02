using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, wynik;
        int typ;

        Console.WriteLine("Podaj 2 liczby:");
        a = inputValue();
        b = inputValue();
        Console.WriteLine("Do wyboru masz: 1 - dodawanie, 2 - odejmowanie, 3 - mnożenie, 4 - dzielenie");
        Console.WriteLine("Jakie działanie chcesz wykonać?");
        typ = (int)inputValue();
        if (typ == 1)
        {
            wynik = a + b;
            Wypisz(wynik);
        }
        else
        {
            if (typ == 2)
            {
                wynik = a - b;
                Wypisz(wynik);
            }
            else
            {
                if (typ == 3)
                {
                    wynik = a * b;
                    Wypisz(wynik);
                }
                else
                {
                    if (b != 0)
                    {
                        wynik = a / b;
                        Wypisz(wynik);
                    }
                    else
                    {
                        Console.WriteLine("Wynik wynosi: " + a + "/" + b);
                    }
                }
            }
        }
    }

    public static void Wypisz(double wynik)
    {
        Console.WriteLine("Wynik wynosi: " + wynik);
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
