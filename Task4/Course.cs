using System;
namespace Task4
{
	public class Course
	{
		List<Student> students { get; set; }
        public int count = 0;
        public Course()
		{
			students =new List <Student>();
			
		}
        public void AddStudent(Student newstudent)
        {
            foreach (var student in students)
            {
                if ( newstudent.Pin==student.Pin)
                {
					Console.WriteLine("sorry your pin must be unique");
					return;
                }
            }
            students.Add(newstudent);
            count++;

        }
		public void RemoveStudent(Student student)
		{
			students.Remove(student);
			count--;
		}

		public void DisplayStudents()
		{
			foreach(var item in students)
			{
				item.GetDetails();
			}
		}

		public void Search(string searchingName)
		{
			foreach(var student in students)
			{
				if (searchingName == student.Name)
				{
					student.GetDetails();

                }

            }

		}

		public void Count()
		{
			Console.WriteLine($"Current student count is : {count}");
		}

		public void Exit()
		{
			Console.WriteLine("You exited from course :(");
		}
    }
}

