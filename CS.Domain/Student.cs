namespace CS.Domain
{
    public class Student
    {
        public Student()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public DateTime Birthday { get; set; }

        public void SetId(Guid id)
        {
            Id = id;
        }
    }
}
