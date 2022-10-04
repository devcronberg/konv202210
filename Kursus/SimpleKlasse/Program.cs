namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Person p = new Person() { Alder = 30, Navn = "a", ErDansk = false };
            Person p = new Person("a", 30, true);


            Terning t = new Terning();

            t.ErSekser += MinSekser;
            //for (int i = 0; i < 10; i++)
            //{
            //    t.Skriv(); 
            //    t.Ryst(); 
            //}

            for (int i = 0; i < 10; i++)
            {
                t.Skriv();
                t.Ryst();
            }
            Console.WriteLine();
            Console.WriteLine();
            LudoTerning l = new LudoTerning();

            for (int i = 0; i < 10; i++)
            {
                l.Skriv();
                l.Ryst();


            }

        }

        public static void MinSekser(int a)
        {
            Console.WriteLine("* - " + a);
        }

    }

    public class Person
    {
        // Fields (brug ikke offentlig felter)...
        public string Navn;
        public int Alder;
        public bool ErDansk;

        // Default
        //public Person()
        //{
        //    // log
        //    // sikkerhed
        //    // validering
        //    this.ErDansk = true;
        //}

        // Custom
        public Person(string navn, int alder, bool ed)
        {
            // log
            // sikkerhed
            // validering
            this.ErDansk = ed;
            this.Navn = navn;
            if (alder < 0)
                throw new ApplicationException("Forkert alder");
            this.Alder = alder;
        }

        // Deconstructor (bruges ikke)
        //~Person() {
        //    // Fjernet fra huk.
        //}

    }


    public class Terning
    {

        public int Værdi;
        public event Action<int> ErSekser;
        private int antal = 0;

        public void Ryst()
        {
            this.Værdi = new Random().Next(1, 7);
            if (this.Værdi == 6 && ErSekser != null)
            {
                antal++;
                ErSekser.Invoke(antal);
            }
        }

        public virtual void Skriv()
        {
            Console.WriteLine("[ " + this.Værdi + " ]");
        }

        public Terning()
        {
            this.Ryst();
        }
    }

    public class LudoTerning : Terning
    {

        public bool ErStjerne()
        {
            return this.Værdi == 3;
        }

        public bool ErGlobus()
        {
            return this.Værdi == 5;
        }
        public LudoTerning()
        {
            this.Ryst();
        }

        public override void Skriv()
        {
            if (this.ErStjerne())
                Console.WriteLine("[ S ]");

            else if (this.ErGlobus())
                Console.WriteLine("[ G ]");
            else
                base.Skriv();
        }
    }

}