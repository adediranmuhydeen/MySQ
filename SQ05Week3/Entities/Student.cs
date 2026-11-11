using System.ComponentModel.DataAnnotations.Schema;

namespace SQ05Week3.Entities;

public class Student
{
    #region Properies
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    [ForeignKey("Class")]
    public int ClassId { get; set; }
    #endregion

    #region Navigating Properties
    public Class Class { get; set; }
    public List<Subject> Subjects { get; set; }
    #endregion

    #region Constructors
    public Student(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public Student(int id, string firstName, string lastName, int age)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public Student(int id, string firstName, string lastName, int age, int classId)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        ClassId = classId;
    }

    private Student()
    {
    }
    #endregion
}
