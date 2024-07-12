
using System.Collections.Generic;
using System.Diagnostics;

namespace Student
{
    internal class Student
    {
        public readonly Dictionary<string, List<int>> grades = new Dictionary<string, List<int>>();

        public void AddGrade(string name, List<int> myGrades)
        {
            foreach (var student in grades)
            {
                if (name == student.Key)
                {
                    foreach (var List in grades.Values)
                    {
                        foreach (var grade in myGrades)
                        {
                            List.Add(grade);
                        }
                    }
                }
                return;
            }
            grades.Add(name, myGrades);
        }
        public void RemoveGrade(string name)
        {
            grades.Remove(name);
        }
        public double GetAverageGrade(string courseName)
        {
            foreach (var key in grades.Keys.ToList())
            {
                if (key == courseName && grades[key].Any())
                {
                    return grades[key].Average();
                }
            }
            return 0;
        }

        public void GetAllGradesByStudents(string name)
        {


            foreach (var students in grades)
            {
                if (name == students.Key)
                {
                    foreach (var List in grades.Values)
                    {
                        for (int i = 0; i < List.Count; i++)
                        {
                            Console.Write(List[i] + " ");
                        }
                        Console.WriteLine(" ");
                        return;
                    }

                }

                Console.WriteLine($"Sorry,we do not have student called {name}");
            }
        }
    }

}
    

