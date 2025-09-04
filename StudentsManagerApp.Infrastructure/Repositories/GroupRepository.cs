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
    public class GroupRepository : IGroupRepository
    {
        StudentsDbContext _dbContext;

        public GroupRepository(StudentsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Group entity)
        {
            _dbContext.Groups.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Group entity)
        {
            _dbContext.Groups.Update(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Group entity)
        {
            _dbContext.Groups.Remove(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Group> GetAll()
        {
            return _dbContext.Groups.AsNoTracking().ToList();
        }

        public Group? GetById(int id)
        {
            return _dbContext.Groups.Find(id);
        }
    }
}
