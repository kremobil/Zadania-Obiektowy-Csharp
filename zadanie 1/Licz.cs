namespace zadanie_1;

public class Licz
{
    private double Wartosc;

    public void Dodaj(double wartosc)
    {
        Wartosc += wartosc;
    }

    public void Odejmij(double wartosc)
    {
        Wartosc -= wartosc;
    }

    public Licz(double wartosc)
    {
        Wartosc = wartosc;
    }

    public void WypiszWartosc()
    {
        Console.WriteLine(Wartosc);
    }
}