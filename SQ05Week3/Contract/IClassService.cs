using SQ05Week3.Entities;

namespace SQ05Week3.Contract;

public interface IClassService
{
    string AddClass(Class addClass);
    bool RemoveClass(int classId);
    Class GetClassById(int classId);
    List<Class> GetAllClass();
}
