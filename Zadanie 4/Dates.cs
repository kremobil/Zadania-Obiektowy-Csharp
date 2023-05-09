namespace Zadanie_4;

public class Dates
{
    public static string DateFormat;

    public static DateTime date
    {
        get
        {
            return date.ToString(DateFormat);
        }
        set
        {
            date = value;
        }
    } = DateTime.Now;

    public static void SetToday()
    {
        date = DateTime.Now;
    }

    public static void MoveToNextWeek()
    {
        date = date.AddDays(7);
    }
    
    public static void MoveToPreviousWeek()
    {
        date = date.AddDays(-7);
    }

    public Dates(string dateFormat)
    {
        DateFormat = dateFormat;
    }
}