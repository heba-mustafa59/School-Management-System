using System;
namespace School_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            School mySchool = new School();
            Teachers t1 = new Teachers(100, "heba", 22);
            Teachers t2 = new Teachers(101, "mustafa", 52);

            Students s1 = new Students(1, "amal", 20);
            Students s2 = new Students(2, "huda", 22);
            Students s3 = new Students(3, "sami", 24);

            Courses c1 = new Courses(200, "OOP", t1);
            Courses c2 = new Courses(201, "c#", t2);

            s1.EnrollInCourse(c1);
            s1.EnrollInCourse(c2);
            s2.EnrollInCourse(c2);
            s3.EnrollInCourse(c1);
            s3.EnrollInCourse(c2);

            mySchool.AddTeacher(t1);
            mySchool.AddTeacher(t2);

            mySchool.AddStudent(s1);
            mySchool.AddStudent(s2);
            mySchool.AddStudent(s3);

            mySchool.AddCourse(c1, t1);
            mySchool.AddCourse(c2, t2);

            mySchool.DisplayAllTeachers();
            mySchool.DisplayAllCourses();
            mySchool.DisplayAllStudents();
            Console.WriteLine("\n-----");
            Console.WriteLine($"School Name: {Students.SCHOOL_NAME}");
            Console.WriteLine($"Total Number of Teachers: {mySchool.totalteachers}");
            Console.WriteLine("----");

        }
    }
}
