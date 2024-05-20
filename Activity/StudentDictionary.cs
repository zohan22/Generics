using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity
{
    public class StudentDictionary
    {
        private Dictionary<string, int> studentGrades;

        public StudentDictionary()
        {
            studentGrades = new Dictionary<string, int>();
        }

        public void AddStudents()
        {
            studentGrades.Add("Brayan", 90);
            studentGrades.Add("Kevin", 85);
            studentGrades.Add("Marco", 78);
            studentGrades.Add("Fernanda", 92);
            studentGrades.Add("Juan", 73);
        }

        public void PrintStudent()
        {
            foreach (var kv in studentGrades)
            {
                Console.WriteLine($"Name: {kv.Key} - Grade: {kv.Value}"); 
            }
        }

        public void UpdateGrade(string studentName, int newGrade)
        {
            if (studentGrades.ContainsKey(studentName))
            {
                studentGrades[studentName] = newGrade;
            }
        }

        public void RemoveStudent(string studentName)
        {
            studentGrades.Remove(studentName);
        }
    }
}
