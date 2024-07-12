namespace Student
{
    public class Program
    {
        public static void Main()
        {
            Student studentManager = new Student();
            studentManager.AddGrade("Ayhan", new List<int> { 85, 90 });
            studentManager.AddGrade("Oktay", new List<int> { 60, 70 });
            Console.WriteLine("All Grades:");
            foreach (var student in studentManager.grades)
            {
                Console.WriteLine($"{student.Key}: [{string.Join(", ", student.Value)}]");
            }
            Console.WriteLine($"Average Grade for Ayhan: {studentManager.GetAverageGrade("Ayhan")}");
            Console.WriteLine($"Average Grade for Oktay: {studentManager.GetAverageGrade("Oktay")}");
            Console.WriteLine("Grades for Ayhan:");
            studentManager.GetAllGradesByStudents("Ayhan");
            studentManager.RemoveGrade("Oktay");
            Console.WriteLine("After removing Oktay:");
            foreach (var student in studentManager.grades)
            {
                Console.WriteLine($"{student.Key}: [{string.Join(", ", student.Value)}]");
            }

            Console.ReadLine();
        }
    }


}
