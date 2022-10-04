using Humanizer;

internal class Program
{
    private static void Main(string[] args)
    {
        Metode1();
        Metode2(1);
        Metode3(1, true, "");

        int res = Metode4();
        string res2 = Metode5("");

        var res3 = LægSammenSimple(5, 4);
        Console.WriteLine(res3.Gns);

        var res4 = MineFunktioner.LægSammen(5, 4, 5);
        Console.WriteLine(res4.gns);

        var res5 = MineFunktioner.LægSammen2(new int[] { 5, 1, 4, 3, 5, 10, 10 });
        Console.WriteLine(res5.gns);

        var res6 = MineFunktioner.LægSammen3(5, 1, 4, 3, 5, 10, 12, 3, 0, 56);
        Console.WriteLine(res6.gns);

        var min = (5, 1, 4);


        string test = "mikkeL";

        // Extension method
        var res7 = test.ToFancy();
        Console.WriteLine(res7);
        var res8 = test.ToFancy();
        Console.WriteLine(res8);

        string c = "Lang tekst som skal forkortes".Truncate(15, " ...");
        Console.WriteLine(c);

        Console.WriteLine((360.0).ToHeading(HeadingStyle.Full));
        Console.WriteLine((130.0).ToHeading(HeadingStyle.Full));

        Console.WriteLine(DateTime.Now.AddDays(-6).Humanize());

        void Metode1() { }

        void Metode2(int a) { }

        void Metode3(int a, bool b, string c)
        {

            if (b == true)
            {
                return;
            }

            // exception


        }

        int Metode4()
        {
            return 0;
        }

        string Metode5(string a)
        {
            if (a == null)
                return "*";


            return a.ToUpper();
        }

        // Egen type
        MinRetur LægSammenSimple(int tal1, int tal2)
        {
            MinRetur m = new MinRetur();
            m.Sum = tal1 + tal2;
            m.Gns = m.Sum / 2;
            return m;
        }
    }
}

public static class MineExtensions
{

    public static string ToFancy(this string txt)
    {
        if (txt == null)
            return string.Empty;

        string res = txt.Substring(0, 1).ToUpper();
        res += txt.Substring(1).ToLower();
        return res;
    }

}

class MinRetur
{
    public double Sum;
    public double Gns;
}

class MineFunktioner
{

    // Tuple
    public static (double sum, double gns, int antal) LægSammen(int tal1, int tal2)
    {
        double s = tal1 + tal2;
        double g = s / 2;
        return (s, g, 2);
    }

    public static (double sum, double gns, int antal) LægSammen(int tal1, int tal2, int tal3)
    {
        double s = tal1 + tal2 + tal3;
        double g = s / 3;
        return (s, g, 3);
    }

    public static (double sum, double gns, int antal) LægSammen(int tal1, int tal2, int tal3, int tal4)
    {
        double s = tal1 + tal2 + tal3 + tal4;
        double g = s / 4;
        return (s, g, 4);
    }

    public static (double sum, double gns, int antal) LægSammen2(int[] tal)
    {
        double s = 0;
        for (int i = 0; i < tal.Length; i++)
        {
            s += tal[i];
        }
        double g = s / tal.Length;
        return (s, g, tal.Length);
    }

    public static (double sum, double gns, int antal) LægSammen3(params int[] tal)
    {
        double s = 0;
        for (int i = 0; i < tal.Length; i++)
        {
            s += tal[i];
        }
        double g = s / tal.Length;
        return (s, g, tal.Length);
    }
}