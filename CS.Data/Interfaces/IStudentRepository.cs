using CS.Domain;

namespace CS.Data.Interfaces
{
    public interface IStudentRepository
    {
        void Add(Student student);
        IEnumerable<Student> GetAll();
        Student Get(Guid id);
        void Update(Guid id, Student student);
        void Delete(Guid id);
    }
}
