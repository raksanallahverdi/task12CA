namespace Task3
{
    public static class Program
    {
        public static void Main()
        {

            GroupList<Group> groups = new();
            Group pb = new("PB401");
            Group pbcopy = new("PB401");
            groups.AddGroup(pb);
            groups.AddGroup(pbcopy);

            groups.GetAll();
            Console.ReadLine();

        }


    }
}



