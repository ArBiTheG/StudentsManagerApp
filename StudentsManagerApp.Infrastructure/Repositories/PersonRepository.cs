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
    public class PersonRepository : IPersonRepository
    {
        StudentsDbContext _dbContext;

        public PersonRepository(StudentsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Person entity)
        {
            _dbContext.Persons.Add(entity);
        }

        public void Update(Person entity)
        {
            _dbContext.Persons.Update(entity);
        }

        public void Delete(Person entity)
        {
            _dbContext.Persons.Remove(entity);
        }

        public IEnumerable<Person> GetAll()
        {
            return _dbContext.Persons.AsNoTracking().ToList();
        }

        public Person? GetById(int id)
        {
            return _dbContext.Persons.Find(id);
        }
    }
}
