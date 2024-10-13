using Sorteringsalgoritm;

internal class Program
{
    public static void Main()
    {
        //instans av klass
        IntSorter sorter = new MergeSort();

        //variable
        int firstN = 10000;
        //skriv ut osorterad

        Console.WriteLine("Unordered:");
        TestSort.testSort(sorter, firstN, false);
        Console.WriteLine("\nOrdered:");

        //skriv ut sorterad
        TestSort.testSort(sorter, firstN, true);

        Console.WriteLine("\n" + sorter.GetType().Name + ".sort tested ok!");
        Environment.Exit(0);
    }
}