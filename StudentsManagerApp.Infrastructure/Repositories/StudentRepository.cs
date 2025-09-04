using Microsoft.EntityFrameworkCore;
using StudentsManagerApp.Application.Common.Repositories;
using StudentsManagerApp.Domain.Models;
using StudentsManagerApp.Infrastructure.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagerApp.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        StudentsDbContext _dbContext;

        public StudentRepository(StudentsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Student entity)
        {
            _dbContext.Students.Add(entity);
        }

        public void Update(Student entity)
        {
            _dbContext.Students.Update(entity);
        }

        public void Delete(Student entity)
        {
            _dbContext.Students.Remove(entity);
        }

        public IEnumerable<Student> GetAll()
        {
            return _dbContext.Students.AsNoTracking().ToList();
        }

        public Student? GetById(int id)
        {
            return _dbContext.Students.Find(id);
        }
    }
}
