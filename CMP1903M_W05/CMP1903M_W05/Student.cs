using System;
using System.Collections.Generic;
using System.Text;

namespace CMP1903M_W05
{
    class Student
    {
        public Student()
        {
            Name = "defaultName";
            Age = 0;
            studentID = 0;
            UniCollege = "defaultCollege";
            year = 1;
        }
        public Student(string name, int age, int StudentID, string uniCollege, int Year)
        {
            Name = name;
            Age = age;
            studentID = StudentID;
            UniCollege = uniCollege;
            year = Year;
        }


        //Some properties describing a Student
        public string Name { get; set; }
        public int Age { get; set; }
        public int studentID { get; set; }
        public string UniCollege { get; set; }
        public string UniSchool { get; set; }
        public int courseID { get; set; }
        public string UniCourse { get; set; }
        public int year { get; set; }

        public void summary()
        {
            Console.WriteLine($"Name = {Name} Age = {Age} Student ID = {studentID} Uni/College = {UniCollege} Year = {year}");
        }
    }
}

