using CS.Domain;
using CS.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<Student> students = _studentService.GetAll();
            return Ok(students);
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            bool cpfIsValid = _studentService.IsCpf(student.CPF);

            if (cpfIsValid)
            {
                _studentService.Add(student);
                return StatusCode(201);
            }

            ModelState.AddModelError("Cpf", "Cpf inválido");
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _studentService.Delete(id);
            return NoContent();
        }


        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            Student student = _studentService.GetById(id);
            return Ok(student);
        }


        [HttpPut("{id}")]
        public IActionResult Update(Guid id, Student student)
        {
            _studentService.Update(id, student);
            return NoContent();
        }
    }
}
