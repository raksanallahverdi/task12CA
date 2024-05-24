using System;
namespace Task2
{
	public class Generic<T>
	{
		public Generic()
		{

		}
		public void Swap(T value1,T value2)
		{
			T value3 = value1;
			value1 = value2;
			value2 = value3;
			Console.WriteLine($"value1: {value1},  value2: {value2}");
		}
	}
}

