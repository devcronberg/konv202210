namespace Egenskaber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.SetAlder(11);

            p.Navn = "a";
            Console.WriteLine(p.Navn);

            Console.WriteLine(p.GetAlder());

            var m = p.GetType().GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);



            Hund d = new Hund { Navn = "a", AntalBen = 4 };
            string json = System.Text.Json.JsonSerializer.Serialize(d);

            Hund g = System.Text.Json.JsonSerializer.Deserialize<Hund>(json);


        }
    }

    public class Person
    {

        private int Alder;
        // public string Navn;

        private string _navn;
        public string Navn
        {
            get {
                // valdering
                // sikkerhed
                // log
                return this._navn;
            }
            set {   // value
                if (value == null)
                    value = string.Empty;
                this._navn = value;
            }
        }


        public int GetAlder()
        {
            // valdering
            // sikkerhed
            // log
            return this.Alder;
        }

        public void SetAlder(int alder)
        {
            if (alder < 0 || alder > 100)
                throw new ApplicationException("Forkert...");
            this.Alder = alder;
        }
    }


    class Hund {
        public int AntalBen { get;  set; } = 4;
        public string Navn { get; set; }
    }

    class Faktura
    {
        // felt (offentlig)
        // public int Nummer;

        //public int Nummer { get; set; }
        private int _nummer;

        public int Nummer
        {
            get { 
                return _nummer; 
            }
            set { 
                // log...
                // 
                _nummer = value; 
            
            }
        }

        public string Kunde { get; set; }

    }
}
