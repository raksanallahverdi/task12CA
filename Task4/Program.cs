using System.Text.RegularExpressions;

namespace Task4
{
    public static class Program
    {
        public static void Main()
        {
            Course codeAcademy = new();
            Student Raksana = new Student("Raksana", "A", 12, "123A");
            Student Nigar = new Student("Nigar", "SH", 15, "9h83h8");
            Student Nuray = new Student("Nuray", "B", 19, "jhj89");
            Student Nuray2 = new Student("Nuray2", "B", 19, "jhj89");
            codeAcademy.AddStudent(Raksana);
            codeAcademy.AddStudent(Nigar);
            codeAcademy.AddStudent(Nuray);
            codeAcademy.AddStudent(Nuray2);
            codeAcademy.RemoveStudent(Nigar);
            codeAcademy.Search("Nuray");
            codeAcademy.Count();
            codeAcademy.DisplayStudents();
            
            codeAcademy.Exit();


            Console.ReadLine();
            
        }



    }
}