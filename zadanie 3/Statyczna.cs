namespace zadanie_3;

public class Statyczna
{
    public int I;
    public static int Liczba;

    public static void Zwiększ()
    {
        Liczba++;
    }

    public Statyczna(int i)
    {
        I = i;
        Zwiększ();
    }
}