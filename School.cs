using System.Security.Cryptography;
namespace School_Management_System;

public class School
{
    private List<Students> studentslist { set; get; }
    private List<Teachers> teacherslist { set; get; }
    private List<Courses> courselist { set; get; }

    public School()
    {
        studentslist = new List<Students>();
        teacherslist = new List<Teachers>();
        courselist = new List<Courses>();
    }
    public void AddStudent(Students student)
    {
        if (student != null)
        {
            studentslist.Add(student);
            Console.WriteLine($"Student '{student.Name}' added to the school successfully.");

        }
    }
    public void AddTeacher(Teachers teacher)
    {
        if (teacher != null)
        {
            teacherslist.Add(teacher);
            Console.WriteLine($"Teacher '{teacher.Name}' added to the school successfully.");
        }
    }
    public void AddCourse(Courses course, Teachers teacher)
    {
        if (course != null)
        {
            course.Teacher = teacher;
            courselist.Add(course);
        }
        if (teacher != null)
        {
            teacher.Assigncourse(course);
        }
        Console.WriteLine($"Course '{course.CourseName}' added to the school successfully.");

    }
    public void DisplayAllStudents()
    {
        Console.WriteLine("\n-- List of All Students --");
        if (studentslist.Count == 0) Console.WriteLine("No students registered yet.");
        foreach (var s in studentslist)
        {
            Console.WriteLine(s.GetStudentDetails());
        }
    }
    public void DisplayAllTeachers()
    {
        Console.WriteLine("\n-- List of All Students --");
        if (teacherslist.Count == 0) Console.WriteLine("No teachers registered yet.");
        foreach (var t in teacherslist)
        {
            Console.WriteLine(t.GetTeacherDetails);
        }
    }
    public void DisplayAllCourses()
    {
        Console.WriteLine("\n=== List of All Courses ===");
        if (courselist.Count == 0) Console.WriteLine("No courses created yet.");
        foreach (var c in courselist)
        {
            Console.WriteLine(c.GetCourseDetails());
        }
    }

    public int totalteachers
    {
        get
        {
            return teacherslist.Count;
        }
    }
}
