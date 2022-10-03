// sæt culture
System.Threading.Thread.CurrentThread.CurrentCulture =
    new System.Globalization.CultureInfo("en-US");
{
    int t = 10;

    // Instans (ToString)
    string a = t.ToString();
    Console.WriteLine(a);

    int max = int.MaxValue;
    Console.WriteLine(max);

    // Instans
    DateTime dt = new DateTime(2022, 1, 1);

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
    if (++g == 4)
    {
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

    bool w;
    Console.WriteLine(bool.FalseString);

    if (true || false) { }

    System.DateTime q = DateTime.Now;
    //System.DateTime q = new DateTime(2022, 1, 1);
    Console.WriteLine(q);
    //Console.WriteLine(q.Minute);

    q = q.AddDays(10);
    //Console.WriteLine(q.ToLongDateString());
    Console.WriteLine(q.ToString("dd. MMMM yy"));

    DateTime q1 = DateTime.Now;
    DateTime q2 = new DateTime(2022, 1, 1);

    TimeSpan q3 = q1.Subtract(q2);
    Console.WriteLine(q3.Days);

}

{

    int a = 100000;
    long b = 22000000000;
    // try/catch
    //a = Convert.ToInt32(Console.ReadLine());
    //a++;
    //Console.WriteLine(a);


    string d = "2022/12/30";
    DateTime e = Convert.ToDateTime(d);
    Console.WriteLine(e);
}

{
    char a = 'A';
    Console.WriteLine(a);
    Console.WriteLine(Convert.ToInt32(a));
    char b = Convert.ToChar(65);
    Console.WriteLine(b);

    


}

{
    string a = "Mathias";
    string b = "Mikkel";
    Console.WriteLine(b);
    b = b.ToUpper();
    Console.WriteLine(b);
    Console.WriteLine(a==b);
    string c = "slkdjfældskfg \r\nalsfh \\ lksdjh laks ";
    Console.WriteLine(c);

    string sti = @"c:\temp\test.txt";
    Console.WriteLine(sti);

    string navn = "Mathias";
    string res = $"Hej - mit navn er { navn }";
    Console.WriteLine(res);

    string t = null;
    //if(t!=null)
        Console.WriteLine(t?.ToUpper());

    //int y = 1;
    //y = null;






}

{
    //// Stopur
    //System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
    //s.Start();
    //string a = "";
    //for (int i = 0; i < 500000; i++)
    //{
    //    a =a + "*";
    //}
    //s.Stop();
    //Console.WriteLine($"ms = {s.ElapsedMilliseconds}");
    // Stopur
    System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
    System.Text.StringBuilder sb = new System.Text.StringBuilder();
    s.Start();
    for (int i = 0; i < 5_000_000; i++)
    {
        sb.Append("*");
    }
    //sb.Insert(100, "**");
    s.Stop();
    Console.WriteLine($"ms = {s.ElapsedMilliseconds}");
}




class Hund {
    public void Test() {
        Console.WriteLine("Test");
    }

    public static void Test2() {
        Console.WriteLine("Test2");
    }

}


