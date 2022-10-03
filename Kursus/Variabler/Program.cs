// sæt culture
System.Threading.Thread.CurrentThread.CurrentCulture =
    new System.Globalization.CultureInfo("da-DK");

int t = 10;

// Instans (ToString)
string a = t.ToString();
Console.WriteLine(a);

int max = int.MaxValue;
Console.WriteLine(max);

// Instans
DateTime dt = new DateTime(2022,1,1);

// Static
bool skud = DateTime.IsLeapYear(2022);
Console.WriteLine(skud);

Console.WriteLine(DateTime.Now);


Hund h = new Hund();
// Instans
h.Test();

// Static
Hund.Test2();


double d1 = 0.1;
double d2 = d1 + d1 + d1 + d1 + d1 + d1 + d1 + d1 + d1 + d1;
Console.WriteLine(d2);

int g = 1;
g++;
++g;
if (++g == 4) {
    Console.WriteLine("*");
}
Console.WriteLine(g);
//checked
{
    byte b = 255;
    Console.WriteLine($"b={b}");
    b++;
    b++;
    b++;
    b++;
    Console.WriteLine($"b={b}");
}

double u = 333333.44542;
Console.WriteLine(u);
Console.WriteLine(u.ToString("N2"));
Console.WriteLine(u.ToString("C2"));
Console.WriteLine(u.ToString("F2"));

double v = 0.25;
Console.WriteLine(v.ToString("P2"));


class Hund {
    public void Test() {
        Console.WriteLine("Test");
    }

    public static void Test2() {
        Console.WriteLine("Test2");
    }

}
