namespace Zadanie_2;

public class Sumator
{
    private List<int> Liczby = new List<int>();

    public int Suma()
    {
        return Liczby.Sum();
    }

    public int SumaPodziel3()
    {
        int suma = 0;
        foreach (var liczba in Liczby)    
        {
            if (liczba % 3 == 0)
            {
                suma += liczba;
            }
        }
        return suma;
    }

    public int IleElementów()
    {
        return Liczby.Count();
    }

    public void WypiszWszystkieElementy()
    {
        Console.Write("[");
        foreach (var liczba in Liczby)
        {
            Console.Write($"{liczba}, ");
        }
        Console.WriteLine("]");
    }

    public void WypiszWybraneElementy(int lowIndex, int highIndex)
    {
        Console.Write("[");
        lowIndex = lowIndex < 0 ? 0 : lowIndex;
        highIndex = highIndex > Liczby.Count()? Liczby.Count() : highIndex;
        for (int i = lowIndex; i < highIndex; i++)
        {
            Console.Write($"{ Liczby[i] }, ");
        }

        Console.WriteLine("]");
    }

    public Sumator()
    {
        Console.WriteLine($"Podaj liczby należące do sumatora");
        Console.Write($"Ile liczb chcesz dodać? : ");
        var repats = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < repats; i++)
        {
            Console.Write($"Podaj {i+1} liczbę: ");
            Liczby.Add(Convert.ToInt32(Console.ReadLine()));
        }
        
    }
}