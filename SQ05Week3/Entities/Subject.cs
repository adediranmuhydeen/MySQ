namespace SQ05Week3.Entities;

public class Subject
{
    public int Id { get; set; }
    public string Name { get; set; }

    #region Navigating Properties
    public List<Student> Students { get; set; }
    #endregion
}
