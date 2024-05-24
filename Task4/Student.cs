using System;
namespace Task4
{
	public class Student
	{
		public string Name { get; set; }
        public string Surname { get; set; }
        public string Pin { get; set; }
		public int Age { get; set; }

        public Student(string name,string surname,int age,string pin)
		{
			Name = name;
			Surname = surname;
			Age = age;
			Pin = pin;
		}

		public void GetDetails()
		{
			Console.WriteLine($"{Name},{Surname},{Age},{Pin}");
		}
	}
}

