using Microsoft.EntityFrameworkCore;
using StudentsManagerApp.Application.Common;
using StudentsManagerApp.Application.Common.Repositories;
using StudentsManagerApp.Infrastructure.Common;
using StudentsManagerApp.Infrastructure.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagerApp.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private StudentsDbContext _dbContext;

        public UnitOfWork(StudentsDbContext dbContext, IPersonRepository persons, IGroupRepository groups, IStudentRepository students)
        {
            _dbContext = dbContext;
            Persons = persons;
            Groups = groups;
            Students = students;
        }

        public IPersonRepository Persons { get; }

        public IGroupRepository Groups { get; }

        public IStudentRepository Students { get; }

        public void Save()
        {
            _dbContext.SaveChanges();
            _dbContext.Database.CommitTransaction();
        }

        public ITransaction BeginTransaction()
        {
            return new Transaction(_dbContext.Database.BeginTransaction());
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }
    }
}
