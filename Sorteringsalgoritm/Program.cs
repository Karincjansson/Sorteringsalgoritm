using Sorteringsalgoritm;

internal class Program
{
    public static void Main()
    {
        //instans av klass
        IntSorter sorter = new MergeSort();

        //variable
        int firstN = 20;
        //skriv ut osorterad

        Console.WriteLine("Unordered:");
        
        int[] unordered = ArrayUtil.CreateShuffeled(firstN);
        PrintArray(unordered);
        //TestSort.testSort(sorter, firstN, false);


        Console.WriteLine("\nOrdered:");
        int[] orderd = ArrayUtil.CreateOrdered(firstN);
        //skriv ut sorterad
        PrintArray(orderd);
        //TestSort.testSort(sorter, firstN, true);


        Console.WriteLine("\n" + sorter.GetType().Name + ".sort tested ok!");
        Environment.Exit(0);
    }
    public static void PrintArray(int[] array)
    {
        foreach (var value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine(); // För att lägga till en ny rad efter utskriften
    }
}