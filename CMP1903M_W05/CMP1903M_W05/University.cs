using System;
using System.Collections.Generic;
using System.Text;

namespace CMP1903M_W05
{
    class University
    {

        public University()
        {
            uniName = "default uni name";
        }
        public University(string Name)
        {
            uniName = Name;
        }
        public string uniName { get; set; }

        public List<Student> students = new List<Student>();

        public void addAStudent(string name, int age, int StudentID, string uniCollege, int Year)
        {
            students.Add(new Student(name, age, StudentID, uniCollege, Year));
        }
        public void outputStudents()
        {
            foreach(Student x in students)
            {
                x.summary();
            }
        }
        public void getNumberOfStudents()
        {
            Console.WriteLine($"Number of students: {students.Count}");
        }
    }
}
