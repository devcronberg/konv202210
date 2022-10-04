// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] a = { 1, 5, 1, 56 };

for (int i = 0; i < a.Length; i++)
{
    int r = a[i];
    Console.WriteLine(r);
}

foreach (int item in a)
{
    Console.WriteLine(item);
}