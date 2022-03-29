using Microsoft.AspNetCore.Mvc;
using StudentProject.Models;
using StudentProject.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService) { _studentService = studentService; }

        [HttpGet("")]
        public async Task<IEnumerable<Student>> GetAllStudents() { return await _studentService.GetAllStudentsAsync(); }

        [HttpGet("{id:int}")]
        public async Task<Student> GetStudentByEmail([FromRoute] int id) { return await _studentService.GetStudentByEmailAsync(id); }
    }
}
