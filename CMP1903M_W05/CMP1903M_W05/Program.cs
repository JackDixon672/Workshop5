using System;

namespace CMP1903M_W05
{
    class Program
    {
        static void Main(string[] args)
        {
            University u = new University("Lincoln");
            u.addAStudent("Jack", 18, 1, "Lincoln", 1);
            u.addAStudent("Ryan", 24, 2, "Lincoln", 1);
            u.addAStudent("Chris", 19, 3, "Lincoln", 1);

            u.outputStudents();
            u.getNumberOfStudents();
        }
    }
}
