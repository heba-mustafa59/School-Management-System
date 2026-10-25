namespace School_Management_System;

public class Courses
{
  public int Id {set;get;}
  public string CourseName{set;get;}
  public Teachers Teacher {set;get;}

  public Courses(int id, string coursename,Teachers teacher)
    {
        Id=id;
        CourseName=coursename;
        Teacher=teacher;
    }

   public string GetCourseDetails()
    {
        string teacherName = Teacher !=null?Teacher.Name:"no teacher";
        return $"--- Course Details ---\n" +
                   $"Course ID: {Id}\n" +
                   $"Course Name: {CourseName}\n" +
                   $"Assigned Teacher: {teacherName}\n";
    }
     public void DisplayCourse()
        {
            Console.WriteLine(GetCourseDetails());
        }


}
