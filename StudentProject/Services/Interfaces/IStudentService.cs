using StudentProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentProject.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllStudentsAsync();
        Task<Student> GetStudentByEmailAsync(int id);
    }
}