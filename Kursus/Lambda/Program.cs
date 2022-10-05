namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Action a = Test1;
            //Action a = () => { Console.WriteLine("Test1"); };

            Action a = () => Console.WriteLine("Test1");
            a();

            //Action<int> b = (int a) => { Console.WriteLine(a); };
            //Action<int> b = (a) => { Console.WriteLine(a); };
            //Action<int> b = a => { Console.WriteLine(a); };
            Action<int> b = a => Console.WriteLine(a);
            b(5);

            //Func<int, int, int> c = (int a, int b) => { return a + b; };
            Func<int, int, int> c = (a, b) => a + b;
            Console.WriteLine(c(5, 5));

            //Func<int, bool> d = Test4;
            //Func<int, bool> d = (int a) => { return a < 8; };
            Func<int, bool> d = a => a < 8;


            Console.WriteLine(d.Invoke(5));

            int[] aa = { 5, 1, 4, 1, 4 };
            Func<int, bool> fu = (int x) => x < 5;
            //var list = aa.Where(x => new Random().Next(1, 3) == 1 ? true : false);

            // benchmark.net

            Action<int> test = (int a) =>
            {
                Console.WriteLine(a);
                Console.Beep();
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("*");
                }
            };

            test(5);
            test(5);
            test(2);
            test(2);


            void test2(int a)
            {
                Console.WriteLine(a);
                Console.Beep();
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("*");
                }
            }


        }


        static void Test1()
        {
            Console.WriteLine("Test1");
        }
        static void Test2(int a)
        {
            Console.WriteLine(a);
        }
        static int Test3(int a, int b)
        {
            return a + b;
        }
        static bool Test4(int a)
        {
            return a < 8;
        }


    }
}