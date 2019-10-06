using BlazorDash.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorDash.Models;

namespace BlazorDash.Services
{
    public class StudentService
    {
        private readonly SchoolContext _context;

        public StudentService(SchoolContext context)
        {
            _context = context;
        }

        public IQueryable<Student> GetStudentsQueryable()
        {
            IQueryable<Student> studentIQ = from s in _context.Students select s;
            return studentIQ;
        }

        public  Task<List<Student>> GetStudentsAsync()
        {
            var students = _context.Students.ToListAsync();
            return students;
        }
    }
}
