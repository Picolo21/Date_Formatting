public class Program
{
    private static void Main(string[] args)
    {
        DateTime dateTime = DateTime.Now;

        Console.WriteLine("Dates Formatting!");
        Console.WriteLine();

        Console.WriteLine("Specific Formats:");
        Console.WriteLine();

        Console.WriteLine("y (year)");
        Console.WriteLine("M (month)");
        Console.WriteLine("d (day)");
        Console.WriteLine("h (hour 12)");
        Console.WriteLine("H (hour 24)");
        Console.WriteLine("m (minute)");
        Console.WriteLine("s (second)");
        Console.WriteLine("f (second fraction)");
        Console.WriteLine("F (second fraction, trailing zeroes are trimmed)");
        Console.WriteLine("t (PM ou AM)");
        Console.WriteLine("z (time zone)");
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------------------------------------------\n");

        PrintYear(dateTime);
        PrintMonth(dateTime);
        PrintDay(dateTime);
        PrintHourWith12Hours(dateTime);
        PrintHourWith24Hours(dateTime);
        PrintMinute(dateTime);
        PrintSecond(dateTime);
        PrintSecondFraction(dateTime);
        PrintSecondFractionTrailingZeroesAreTrimmed(dateTime);
        PrintPmOrAm(dateTime);
        PrintTimeZone(dateTime);
    }

    private static void PrintYear(DateTime dateTime)
    {
        Console.WriteLine("YEAR");
        Console.WriteLine();

        Console.WriteLine("DateTime.Now (ToString(y)) ".PadRight(31) + "= " + dateTime.ToString("y"));
        Console.WriteLine("DateTime.Now (ToString(yy)) ".PadRight(31) + "= " + dateTime.ToString("yy"));
        Console.WriteLine("DateTime.Now (ToString(yyy)) ".PadRight(31) + "= " + dateTime.ToString("yyy"));
        Console.WriteLine("DateTime.Now (ToString(yyyy)) ".PadRight(31) + "= " + dateTime.ToString("yyyy"));
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------------------------------------------\n");
    }

    private static void PrintMonth(DateTime dateTime)
    {
        Console.WriteLine("MONTH");
        Console.WriteLine();

        Console.WriteLine("DateTime.Now (ToString(M)) ".PadRight(31) + "= " + dateTime.ToString("M"));
        Console.WriteLine("DateTime.Now (ToString(MM)) ".PadRight(31) + "= " + dateTime.ToString("MM"));
        Console.WriteLine("DateTime.Now (ToString(MMM)) ".PadRight(31) + "= " + dateTime.ToString("MMM"));
        Console.WriteLine("DateTime.Now (ToString(MMMM)) ".PadRight(31) + "= " + dateTime.ToString("MMMM"));
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------------------------------------------\n");
    }

    private static void PrintDay(DateTime dateTime)
    {
        Console.WriteLine("DAY");
        Console.WriteLine();

        Console.WriteLine("DateTime.Now (ToString(d)) ".PadRight(31) + "= " + dateTime.ToString("d"));
        Console.WriteLine("DateTime.Now (ToString(dd)) ".PadRight(31) + "= " + dateTime.ToString("dd"));
        Console.WriteLine("DateTime.Now (ToString(ddd)) ".PadRight(31) + "= " + dateTime.ToString("ddd"));
        Console.WriteLine("DateTime.Now (ToString(dddd)) ".PadRight(31) + "= " + dateTime.ToString("dddd"));
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------------------------------------------\n");
    }

    private static void PrintHourWith12Hours(DateTime dateTime)
    {
        Console.WriteLine("HOUR (h)");
        Console.WriteLine();

        Console.WriteLine("DateTime.Now (ToString(hh)) ".PadRight(31) + "= " + dateTime.ToString("hh"));
        Console.WriteLine("DateTime.Now (ToString(hhh)) ".PadRight(31) + "= " + dateTime.ToString("hhh"));
        Console.WriteLine("DateTime.Now (ToString(hhhh)) ".PadRight(31) + "= " + dateTime.ToString("hhhh"));
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------------------------------------------\n");
    }

    private static void PrintHourWith24Hours(DateTime dateTime)
    {
        Console.WriteLine("HOUR (H)");
        Console.WriteLine();

        Console.WriteLine("DateTime.Now (ToString(HH)) ".PadRight(31) + "= " + dateTime.ToString("HH"));
        Console.WriteLine("DateTime.Now (ToString(HHH)) ".PadRight(31) + "= " + dateTime.ToString("HHH"));
        Console.WriteLine("DateTime.Now (ToString(HHHH)) ".PadRight(31) + "= " + dateTime.ToString("HHHH"));
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------------------------------------------\n");
    }

    private static void PrintMinute(DateTime dateTime)
    {
        Console.WriteLine("MINUTE");
        Console.WriteLine();

        Console.WriteLine("DateTime.Now (ToString(m)) ".PadRight(31) + "= " + dateTime.ToString("m"));
        Console.WriteLine("DateTime.Now (ToString(mm)) ".PadRight(31) + "= " + dateTime.ToString("mm"));
        Console.WriteLine("DateTime.Now (ToString(mmm)) ".PadRight(31) + "= " + dateTime.ToString("mmm"));
        Console.WriteLine("DateTime.Now (ToString(mmmm)) ".PadRight(31) + "= " + dateTime.ToString("mmmm"));
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------------------------------------------\n");
    }

    private static void PrintSecond(DateTime dateTime)
    {
        Console.WriteLine("SECOND");
        Console.WriteLine();

        Console.WriteLine("DateTime.Now (ToString(s)) ".PadRight(31) + "= " + dateTime.ToString("s"));
        Console.WriteLine("DateTime.Now (ToString(ss)) ".PadRight(31) + "= " + dateTime.ToString("ss"));
        Console.WriteLine("DateTime.Now (ToString(sss)) ".PadRight(31) + "= " + dateTime.ToString("sss"));
        Console.WriteLine("DateTime.Now (ToString(ssss)) ".PadRight(31) + "= " + dateTime.ToString("ssss"));
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------------------------------------------\n");
    }

    private static void PrintSecondFraction(DateTime dateTime)
    {
        Console.WriteLine("SECOND FRACTION (f)");
        Console.WriteLine();

        Console.WriteLine("DateTime.Now (ToString(f)) ".PadRight(31) + "= " + dateTime.ToString("f"));
        Console.WriteLine("DateTime.Now (ToString(ff)) ".PadRight(31) + "= " + dateTime.ToString("ff"));
        Console.WriteLine("DateTime.Now (ToString(fff)) ".PadRight(31) + "= " + dateTime.ToString("fff"));
        Console.WriteLine("DateTime.Now (ToString(ffff)) ".PadRight(31) + "= " + dateTime.ToString("ffff"));
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------------------------------------------\n");
    }

    private static void PrintSecondFractionTrailingZeroesAreTrimmed(DateTime dateTime)
    {
        Console.WriteLine("SECOND FRACTION, TRAILING ZEROES ARE TRIMMED (F)");
        Console.WriteLine();

        Console.WriteLine("DateTime.Now (ToString(F)) ".PadRight(31) + "= " + dateTime.ToString("F"));
        Console.WriteLine("DateTime.Now (ToString(FF)) ".PadRight(31) + "= " + dateTime.ToString("FF"));
        Console.WriteLine("DateTime.Now (ToString(FFF)) ".PadRight(31) + "= " + dateTime.ToString("FFF"));
        Console.WriteLine("DateTime.Now (ToString(FFFF)) ".PadRight(31) + "= " + dateTime.ToString("FFFF"));
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------------------------------------------\n");
    }

    private static void PrintPmOrAm(DateTime dateTime)
    {
        Console.WriteLine("PM or AM");
        Console.WriteLine();

        Console.WriteLine("DateTime.Now (ToString(t)) ".PadRight(31) + "= " + dateTime.ToString("t"));
        Console.WriteLine("DateTime.Now (ToString(tt)) ".PadRight(31) + "= " + dateTime.ToString("tt"));
        Console.WriteLine("DateTime.Now (ToString(ttt)) ".PadRight(31) + "= " + dateTime.ToString("ttt"));
        Console.WriteLine("DateTime.Now (ToString(tttt)) ".PadRight(31) + "= " + dateTime.ToString("tttt"));
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------------------------------------------\n");
    }

    private static void PrintTimeZone(DateTime dateTime)
    {
        Console.WriteLine("TIME ZONE");
        Console.WriteLine();

        Console.WriteLine("DateTime.Now (ToString(zz)) ".PadRight(31) + "= " + dateTime.ToString("zz"));
        Console.WriteLine("DateTime.Now (ToString(zzz)) ".PadRight(31) + "= " + dateTime.ToString("zzz"));
        Console.WriteLine("DateTime.Now (ToString(zzzz)) ".PadRight(31) + "= " + dateTime.ToString("zzzz"));
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------------------------------------------\n");
    }
}