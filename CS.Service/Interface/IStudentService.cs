using CS.Domain;

namespace CS.Service.Interface
{
    public interface IStudentService
    {
        void Add(Student student);
        IEnumerable<Student> GetAll();
        Student GetById(Guid id);
        void Update(Guid id, Student student);
        void Delete(Guid id);
        bool IsCpf(string cpf);
    }
}
