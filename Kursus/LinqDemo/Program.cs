namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mappe = new System.IO.DirectoryInfo(@"c:\Microsoft");
            var filer = mappe.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
            Console.WriteLine($"Har fundet {filer.Length} i {mappe.Name}");

            var f = filer.Where(i => i.Length > 100000).Skip(10).Take(5);
            foreach (var item in f)
            {
                Console.WriteLine(item.FullName);
            }
        }
    }

    class MT
    {
        public long Length { get; set; }
        public string Name { get; set; }
    }
}