using System.Security.Cryptography;
using System.Collections.Generic;

namespace School_Management_System;

public class Teachers
{
    public int Id {set;get;}
    public string Name{set;get;}
    public int Age{set;get;}
    public readonly DateTime AdmissionDate;
    public const string SCHOOL_NAME="Palestine School"; 
    private List<Courses> AssignedCourses{set;get;}
    public  Teachers(int id, string name, int age)
    {
       Id=id;
       Name=name;
       Age= age;
       AdmissionDate = DateTime.Now;
       AssignedCourses = new List<Courses>();

    }
    public void Assigncourse(Courses course)
    {
        if (course != null)
        {
            AssignedCourses.Add(course);
            Console.WriteLine($"Course '{course}' has been successfully assigned to Teacher {Name}.");
        }
    }
    public List<Courses> GetAssignedCourses()
    {
      return  AssignedCourses;
    }
    public string GetTeacherDetails()
    {
        List<string> courseName = new List<string>();
        string courses = AssignedCourses.Count>0? string.Join(", ",AssignedCourses):"No courses assigned yet";
        
        return $"--student details--\n"+
               $"ID:{Id}\n"+
               $"Age: {Age}\n" +
               $"School: {SCHOOL_NAME}\n" +
               $"Admission Date: {AdmissionDate}\n" +
               $"Assigned Courses: {courses}\n";
    }

}
