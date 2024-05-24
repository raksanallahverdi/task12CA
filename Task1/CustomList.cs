
public class CustomList<T>
	{
		private T[] values;
		private int count;
		private int capacity;
        public T[] Values { get=>values; }
		public int Capacity { get; set; }
		public int Count { get; set; }

        public CustomList()
		{
			values = new T[0];
			capacity = values.Length;
		
		}

		public void Add(T value)
		{
			if (count == capacity)
			{
				Array.Resize(ref values, capacity == 0 ? 4 : values.Length * 2);
			capacity = values.Length;
			}
			values[count] = value;
			count++;
		}

		public void Remove(T value)
		{
			int index = Array.IndexOf(values, value);
			if (index != -1)
			{
				for (int i = index; i < count; i++)
				{
					values[i] = values[i + 1];
					
				}
                count--;
            }

		}

		public void GetAll()
		{
		foreach(var item in values)
		{
			Console.WriteLine(item);
		}

		}

		public bool Contains(T item)
		{
		int index = Array.IndexOf(values, item);
		if (index != -1)
		{
			return true;
		}
		return false;

		}

		public bool Any()
		{
			if (values.Length > 0)
			{
			return true;
			}
		return false;
		}

	public void Clear()
	{
		for (int i=0; i < count; i++)
		{
			values[i] = default;
		}

		count = 0;
	}

	public T FirstOrDefault()
	{
		if (count >0)
		{
			return values[0]; 
		}
		
		return default;
		
	}

	public T ElementAtOrDefault(int index)
	{
		if (index>0 && index < count)
		{
			return values[index];
		}

		return default;

	}

	public T LastOrDefault()
	{
		if (Any())
		{
			return values[count];
		}
		return default;
	}

}

