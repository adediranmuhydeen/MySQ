using SQ05Week3.Entities;

namespace SQ05Week3.Contract;

public interface IStudentService
{
    string AddStudent(Student addClass);
    bool RemoveStudent(int studentId);
    Student GetStudentById(int studentId);
    List<Student> GetAllStudent();
}
