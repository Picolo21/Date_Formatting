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
        Console.WriteLine("--------------------------------------------------------------------------\n");

        Console.WriteLine("YEAR");
        Console.WriteLine();

        Console.WriteLine("DateTime.Now (ToString(y)) = " + dateTime.ToString("y"));
        Console.WriteLine("DateTime.Now (ToString(yy)) = " + dateTime.ToString("yy"));
        Console.WriteLine("DateTime.Now (ToString(yyy)) = " + dateTime.ToString("yyy"));
        Console.WriteLine("DateTime.Now (ToString(yyyy)) = " + dateTime.ToString("yyyy"));
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------------------\n");

        Console.WriteLine("MONTH");
        Console.WriteLine();

        Console.WriteLine("DateTime.Now (ToString(M)) = " + dateTime.ToString("M"));
        Console.WriteLine("DateTime.Now (ToString(MM)) = " + dateTime.ToString("MM"));
        Console.WriteLine("DateTime.Now (ToString(MMM)) = " + dateTime.ToString("MMM"));
        Console.WriteLine("DateTime.Now (ToString(MMMM)) = " + dateTime.ToString("MMMM"));
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------------------\n");

        Console.WriteLine("DAY");
        Console.WriteLine();

        Console.WriteLine("DateTime.Now (ToString(d)) = " + dateTime.ToString("d"));
        Console.WriteLine("DateTime.Now (ToString(dd)) = " + dateTime.ToString("dd"));
        Console.WriteLine("DateTime.Now (ToString(ddd)) = " + dateTime.ToString("ddd"));
        Console.WriteLine("DateTime.Now (ToString(dddd)) = " + dateTime.ToString("dddd"));
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------------------\n");

        Console.WriteLine("HOUR (h)");
        Console.WriteLine();

        Console.WriteLine("DateTime.Now (ToString(hh)) = " + dateTime.ToString("hh"));
        Console.WriteLine("DateTime.Now (ToString(hhh)) = " + dateTime.ToString("hhh"));
        Console.WriteLine("DateTime.Now (ToString(hhhh)) = " + dateTime.ToString("hhhh"));
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------------------\n");

        Console.WriteLine("HOUR (H)");
        Console.WriteLine();

        Console.WriteLine("DateTime.Now (ToString(HH)) = " + dateTime.ToString("HH"));
        Console.WriteLine("DateTime.Now (ToString(HHH)) = " + dateTime.ToString("HHH"));
        Console.WriteLine("DateTime.Now (ToString(HHHH)) = " + dateTime.ToString("HHHH"));
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------------------\n");

        Console.WriteLine("MINUTE");
        Console.WriteLine();

        Console.WriteLine("DateTime.Now (ToString(m)) = " + dateTime.ToString("m"));
        Console.WriteLine("DateTime.Now (ToString(mm)) = " + dateTime.ToString("mm"));
        Console.WriteLine("DateTime.Now (ToString(mmm)) = " + dateTime.ToString("mmm"));
        Console.WriteLine("DateTime.Now (ToString(mmmm)) = " + dateTime.ToString("mmmm"));
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------------------\n");

        Console.WriteLine("SECOND");
        Console.WriteLine();

        Console.WriteLine("DateTime.Now (ToString(s)) = " + dateTime.ToString("s"));
        Console.WriteLine("DateTime.Now (ToString(ss)) = " + dateTime.ToString("ss"));
        Console.WriteLine("DateTime.Now (ToString(sss)) = " + dateTime.ToString("sss"));
        Console.WriteLine("DateTime.Now (ToString(ssss)) = " + dateTime.ToString("ssss"));
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------------------\n");

        Console.WriteLine("SECOND FRACTION");
        Console.WriteLine();

        Console.WriteLine("DateTime.Now (ToString(f)) = " + dateTime.ToString("f"));
        Console.WriteLine("DateTime.Now (ToString(ff)) = " + dateTime.ToString("ff"));
        Console.WriteLine("DateTime.Now (ToString(fff)) = " + dateTime.ToString("fff"));
        Console.WriteLine("DateTime.Now (ToString(ffff)) = " + dateTime.ToString("ffff"));
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------------------\n");

        Console.WriteLine("SECOND FRACTION, TRAILING ZEROES ARE TRIMMED");
        Console.WriteLine();

        Console.WriteLine("DateTime.Now (ToString(F)) = " + dateTime.ToString("F"));
        Console.WriteLine("DateTime.Now (ToString(FF)) = " + dateTime.ToString("FF"));
        Console.WriteLine("DateTime.Now (ToString(FFF)) = " + dateTime.ToString("FFF"));
        Console.WriteLine("DateTime.Now (ToString(FFFF)) = " + dateTime.ToString("FFFF"));
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------------------\n");

        Console.WriteLine("PM or AM");
        Console.WriteLine();

        Console.WriteLine("DateTime.Now (ToString(t)) = " + dateTime.ToString("t"));
        Console.WriteLine("DateTime.Now (ToString(tt)) = " + dateTime.ToString("tt"));
        Console.WriteLine("DateTime.Now (ToString(ttt)) = " + dateTime.ToString("ttt"));
        Console.WriteLine("DateTime.Now (ToString(tttt)) = " + dateTime.ToString("tttt"));
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------------------\n");

        Console.WriteLine("TIME ZONE");
        Console.WriteLine();

        Console.WriteLine("DateTime.Now (ToString(zz)) = " + dateTime.ToString("zz"));
        Console.WriteLine("DateTime.Now (ToString(zzz)) = " + dateTime.ToString("zzz"));
        Console.WriteLine("DateTime.Now (ToString(zzzz)) = " + dateTime.ToString("zzzz"));
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------------------\n");
    }
}