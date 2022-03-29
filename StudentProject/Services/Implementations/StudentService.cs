using Microsoft.EntityFrameworkCore;
using StudentProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentProject.Services
{
    public class StudentService : IStudentService
    {
        private readonly schoolContext _context;

        public StudentService(schoolContext context)
        {
            _context = context;
            _context.ChangeTracker.LazyLoadingEnabled = false;
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync() { return await _context.Students.Include(student => student.Subjects).ToListAsync(); }

        public async Task<Student> GetStudentByEmailAsync(int id) { return await _context.Students.Include(student => student.Subjects).FirstAsync(x => x.Id == id); }
    }
}
