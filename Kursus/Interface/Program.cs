using System.Net;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        
        A a = new A();
        B b = new B();

        IMitInterface c = b;
        //c.Test1();

        List<IMitInterface> l = new List<IMitInterface>();
        l.Add(a);
        l.Add(b);
        l.Add(new A());

        foreach (var item in l)
        {
            item.Test1();
        }
        Console.WriteLine();

        Terning t = new Terning(new TilfældighedsGeneratorUniverset());
        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine(t.Værdi);
            t.Ryst();
        }
    }
}

class TilfældighedsGeneratorUniverset : ITilfældighedsGenerator
{
    public int TilfældigVærdi(int min, int max)
    {
        using (WebClient w = new WebClient())
        {
            string s = w.DownloadString("https://www.random.org/integers/?num=1&min=1&max=6&col=1&base=10&format=plain&rnd=new");
            return Convert.ToInt32(s);
        }
    }
}








class Terning {
    public int Værdi { get; private set; }
    
    private ITilfældighedsGenerator rnd;
    
    public void Ryst() {
        this.Værdi = rnd.TilfældigVærdi(1, 7);
    }
    public Terning(ITilfældighedsGenerator generator = null)
    {
        if (generator == null)
            generator = new TilfældighedsGeneratorRandom();
        rnd = generator;
        Ryst();
    }
}

interface ITilfældighedsGenerator {
    int TilfældigVærdi(int min, int max);
}

class TilfældighedsGeneratorRandom : ITilfældighedsGenerator
{
    public int TilfældigVærdi(int min, int max)
    {
        return new Random().Next(min, max);
    }
}

class TilfældighedsGeneratorMock : ITilfældighedsGenerator
{
    public int TilfældigVærdi(int min, int max)
    {
        return 6;
    }
}


class A : IMitInterface
{
    public void Test1()
    {
        Console.WriteLine("A");
    }

    public void Test2(int a)
    {
        
    }
}

class B : IMitInterface
{
    public void Test1()
    {
        Console.WriteLine("B");
    }

    public void Test2(int a)
    {
        
    }
}

interface IMitInterface  {

    void Test1();
    void Test2(int a);

}