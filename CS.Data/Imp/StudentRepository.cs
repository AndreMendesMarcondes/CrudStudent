using CS.Data.Interfaces;
using CS.Domain;
using Microsoft.EntityFrameworkCore;

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
            Student student = GetById(id);

            if (student != null)
            {
                _db.Students.Remove(student);
                _db.SaveChanges();
            }
        }

        public Student GetById(Guid id)
        {
            return _db.Students.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Student> GetAll()
        {
            return _db.Students;
        }

        public void Update(Guid id, Student studentDTO)
        {
            Student student = GetById(id);

            if (student != null)
            {
                studentDTO.SetId(student.Id);
                _db.Students.Update(studentDTO);
                _db.SaveChanges();
            }
        }
    }
}
