namespace Nedarvning
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bil b = new Bil { Model = "a", Motor = 1, Produktion = DateTime.Now };
            Console.WriteLine(b);


            List<A> lst = new List<A>();
            lst.Add(new B());
            lst.Add(new A());
        }
    }



    class A {

        private int privatNummer;

        protected void setPrivatNummmer(int value) {
            this.privatNummer = value;
        }
        //protected int privatNummer;
        public int Id { get; set; }
        public virtual void Test() {
            Console.WriteLine("I test (A)");
        }
        public A()
        {
            privatNummer = 1;
        }

        public virtual void TT() { }

        public override string ToString()
        {
            return "A";
        }

    }

    class B : A {
        public int Nummer { get; set; }

        


        public void NyTest() { 
            
        }

        public B()
        {
            
        }

        public override void Test()
        {
            Console.WriteLine("I test (B)");
        }

        public override string ToString()
        {
            return "B";
        }
    }

    class C { }


    class Bil {
        public string Model { get; set; }
        public int Motor { get; set; }
        public DateTime Produktion { get; set; }
        public bool ErGod { get; set; }

        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize(this);
        }
    }
}