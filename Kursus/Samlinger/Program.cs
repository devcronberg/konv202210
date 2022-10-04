namespace Samlinger
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                if (args.Length > 0)
                {
                    foreach (var item in args)
                    {
                        Console.WriteLine("Arg: " + item);
                    }
                }

                {
                    int[] a = new int[10];
                    a[0] = 1;
                    a[9] = 1;

                    int[] b = new int[] { 5, 1, 4, 1, 6 };
                    int[] c = { 5, 1, 4, 1, 6 };

                    Console.WriteLine(FindMindsteVærdi(c));
                    Console.WriteLine(c.Min());

                    
                    for (int i = 0; i < b.Length; i++)
                        Console.WriteLine(b[i]);

                    foreach (var item in b)
                        Console.WriteLine(item);

                    System.Array.ForEach(b, i => Console.WriteLine(i));

                }
            }


            {

                List<string> a = new List<string>();
                a.Add("3");
                a.Add("1");
                a.Insert(0, "2");

                

                //Console.WriteLine();
                //Console.WriteLine();
                //for (int i = 0; i < a.Count; i++)
                //{
                //    Console.WriteLine(a[i]);
                //}

                Stack<int> stack = new Stack<int>();
                stack.Push(3);
                stack.Push(2);
                stack.Push(1);
                int r = stack.Pop();

                Queue<string> queue = new Queue<string>();
                queue.Enqueue("a");
                queue.Enqueue("b");
                queue.Enqueue("c");

                string y = queue.Dequeue();
                
                Dictionary<string, int> map = new Dictionary<string, int>();
                map.Add("a", 1);
                map.Add("b", 2);
                map.Add("c", 3);

                Console.WriteLine(map.ContainsKey("a"));
                Console.WriteLine(map.ContainsValue(10));

                int d = map["cs"];




            }



        }

        static int FindMindsteVærdi_FEJL(int[] array)
        {
            // Sorterer det oprindelige array!!!
            System.Array.Sort(array);
            return array[0];
        }






        static int FindMindsteVærdi(int[] array)
        {
            int[] kopi = array.Clone() as int[];
            System.Array.Sort(kopi);
            return kopi[0];
        }
    }
}