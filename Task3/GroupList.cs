using System;
namespace Task3
{
	public class GroupList<T> where T : Group
        
    {
		private T[] groups;
		public T[] Groups { get => groups; }
		public GroupList()
		{
			groups = new T[0];
		}

        public void GetAll()
        {
            foreach (var group in groups)
            {
                group.GetDetails();
            }

        }

        public void AddGroup(T group)
		{
			foreach(var exist in groups)
			{
                if (exist.Name==group.Name)
                {
                    Console.WriteLine("This group already exists..");
					return;
                }
                
            }
            Array.Resize(ref groups, groups.Length + 1);
            groups[groups.Length - 1] = group;


        }
		
	}
}

