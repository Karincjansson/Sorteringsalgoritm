internal class Program
{
    public static void Main()
    {
        IntSorter sorter = new InsertionSorter();

        int firstN = 10000;

        Console.WriteLine("Unordered:");
        TestSort.testSort(sorter, firstN, false);
        Console.WriteLine("\nOrdered:");
        TestSort.testSort(sorter, firstN, true);

        Console.WriteLine("\n" + sorter.GetType().Name + ".sort tested ok!");
        Environment.Exit(0);
    }
}