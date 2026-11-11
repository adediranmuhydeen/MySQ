using SQ05Week3.Contract;
using SQ05Week3.Entities;

namespace SQ05Week3.Services;

public class StudentService : IStudentService
{
    List<Student> students = new List<Student>
    {
        new Student(1, "Shukurah", "Lawal", 16, 1),
        new Student(1, "Ajose", "Emanuel", 26, 1),
        new Student(1, "James", "Best", 21, 2),
        new Student(1, "Opeyemi", "Kolawole", 19, 2),
        new Student(1, "Fatimah", "Lawal", 22, 3),
        new Student(1, "Wariz", "Bello", 18, 3),
    };

    #region Public Methods
    public string AddStudent(Student student)
    {
        students.Add(student);
        return "Student added successfully";
    }

    public List<Student> GetAllStudent()
    {
        return students;
    }

    public Student GetStudentById(int studentId)
    {
        var result = students.FirstOrDefault(x => x.Id == studentId);
        return result;
    }

    public bool RemoveStudent(int studentId)
    {
        var student = students.FirstOrDefault(a => a.Id == studentId);
        if(student == null)
        {
            return false;
        }
        students.Remove(student);
        return true;
    }

    #endregion
}
