namespace School_Management_System;
using System.Collections.Generic;
public class Students
{
  public int Id{set;get;}
  public string Name{set;get;}
  public int Age {set; get;}
  public readonly DateTime AdmissionDate;
  public const string SCHOOL_NAME="Palestine School"; 

  public Students(int id, string name, int age)
    {
        Id=id;
        Name=name;
        Age=age;

        AdmissionDate=DateTime.Now;
        EnrolledCourses = new List<Courses>();
    }

  private List<Courses> EnrolledCourses {set;get;}
  public void EnrollInCourse(Courses course)
        {
            if (course != null)
            {
                EnrolledCourses.Add(course);
                 Console.WriteLine($"Student {Name} successfully enrolled in {course.CourseName}.");
            }
}
  
  public List<Courses> GetEnrolledCourses()
    {
        return EnrolledCourses;
    }
   public string GetStudentDetails()
        {
             List<string> courseNames = new List<string>();
            foreach (var c in EnrolledCourses)
            {
                courseNames.Add(c.CourseName);
            }

            string courses = courseNames.Count > 0 ? string.Join(", ", courseNames) : "No courses enrolled yet";
            
         return $"--student details--\n"+
        $"ID:{Id}\n"+
        $"Age: {Age}\n" +
        $"School: {SCHOOL_NAME}\n" +
        $"Admission Date: {AdmissionDate}\n" +
        $"Enrolled Courses: {courses}\n";
    }

}
