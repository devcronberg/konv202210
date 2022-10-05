namespace Delegates
{
    internal class Program
    {

        // Action
        delegate void MinDelegate1();
        delegate void MinDelegate2(int a);

        // Func
        delegate int MinDelegate3(int a, int b);

        // Predicate        
        delegate bool MinDelegate4(int a);


        static void Main(string[] args)
        {
            // Direkte kald
            Test1();
            Test2(1);
            Console.WriteLine(Test3(1, 1));
            Console.WriteLine(Test4(5));

            Console.WriteLine();

            // Inddirekte
            MinDelegate1 d1 = Test1;
            Action d1a = Test1;
            //d1.Invoke();
            if(d1!=null)
                d1.Invoke();

            MinDelegate2 d2 = new MinDelegate2(Test2);
            Action<int> d2a = Test2;
            d2.Invoke(4);

            MinDelegate3 d3 = new MinDelegate3(Test3);
            Func<int, int, int> d3a = Test3;
            Console.WriteLine(d3.Invoke(5,5));

            MinDelegate4 d4 = new MinDelegate4(Test4);
            Predicate<int> d4a = Test4;
            Func<int, bool> d4b = Test4;
            Console.WriteLine(d4a.Invoke(4));
            Console.WriteLine(d4b.Invoke(4));

            Console.WriteLine();

            //Prøv(d1);
            MinDelegate1 d5 = Test1;
            Prøv(d5);

            Console.WriteLine();
            Console.WriteLine();

            MinDelegate1 d6 = Test1;
            d6 += Test1;
            d6 += Console.WriteLine;
            d6 += Test1;
            d6 += Console.WriteLine;
            d6 += Test1;
            d6 += Console.WriteLine;
            d6 += Test1;

            //d6 = null;
            d6();

            Terning t = new Terning(new RystDelegate(Fv));
            //Terning t = new Terning(Fv);
            //Terning t = new Terning(new Random().Next);
            Console.WriteLine(t.Værdi);
            
            t.Ryst();
            Console.WriteLine(t.Værdi);


            int[] a = { 40, 7, 1, 10, 9, 5 };

            //int index = System.Array.FindIndex(a, d4a);
            int index = System.Array.FindIndex(a, Test4);
            Console.WriteLine(index);


            List<int> b = new() { 40, 7, 1, 10 };
            //b.ForEach(a => Console.WriteLine(a));
            b.ForEach(Test2);

        }

        static int Fv(int m, int ma) {
            return new Random().Next(1, 7);
        }

        static void Prøv(MinDelegate1 action) {
            // ldkd sæj g
            action.Invoke();
        }

        static MinDelegate1 FindDelegate()
        {
            // 
            return Test1;
        }

        static void Test1() {
            Console.WriteLine("Test1");
        }
        static void Test2(int a) {
            Console.WriteLine(a);
        }
        static int  Test3(int a, int b) {
            return a + b;
        }
        static bool Test4(int a) {
            return a < 8;
        }

    }

    delegate int RystDelegate(int min, int max);

    class Terning
    {
        public int Værdi { get; private set; }
        private RystDelegate RystDelegate;

        public Terning(RystDelegate RystDelegate)
        {
            this.RystDelegate = RystDelegate;
            Ryst();
        }

        public void Ryst() {
            if (RystDelegate != null)
                this.Værdi = RystDelegate.Invoke(1, 7);
            else
            {
                this.Værdi = 1;
            }
        }


    }
}