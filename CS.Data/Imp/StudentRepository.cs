using CS.Data.Interfaces;
using CS.Domain;

namespace CS.Data.Imp
{
    public class StudentRepository : IStudentRepository
    {
        private readonly MainContext _db;

        public StudentRepository(MainContext db)
        {
            _db = db;
        }

        public void Add(Student student)
        {
            _db.Students.Add(student);
            _db.SaveChanges();
        }

        public void Delete(Guid id)
        {
            Student student = Get(id);

            if (student != null)
            {
                _db.Students.Remove(student);
                _db.SaveChanges();
            }
        }

        public Student Get(Guid id)
        {
            return _db.Students.First(x => x.Id == id);
        }

        public IEnumerable<Student> GetAll()
        {
            return _db.Students;
        }

        public void Update(Guid id, Student studentDTO)
        {
            Student student = Get(id);

            if (student != null)
            {
                studentDTO.SetId(student.Id);
                _db.Students.Update(studentDTO);
                _db.SaveChanges();
            }
        }
    }
}
