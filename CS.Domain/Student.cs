using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CS.Domain
{
    [Table("Student")]
    public class Student
    {
        public Student()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required]
        public DateTime Birthday { get; set; }

        public void SetId(Guid id)
        {
            Id = id;
        }
    }
}
