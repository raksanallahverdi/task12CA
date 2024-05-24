public static class Program
{
    public static void Main()
    {
        CustomList<int> myList = new CustomList<int>();
        myList.Add(5);
        myList.Add(4);
        myList.Add(9);
        myList.Add(8);
        myList.Add(2);
        myList.Remove(5);
        Console.WriteLine(myList.Contains(5));
        Console.WriteLine(myList.FirstOrDefault());
        Console.WriteLine(myList.ElementAtOrDefault(2));
        Console.WriteLine(myList.LastOrDefault());
        //myList.Clear();
        //myList.GetAll();
        Console.ReadLine();

    }

   
}

