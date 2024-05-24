using System;
namespace Task3
{
	public class Group
	{
		public string Name { get; set; }
		public Group(string name)
		{
			Name = name;
		}
		public void GetDetails()
		{
			Console.WriteLine($"{Name}");
		}
	}
}

