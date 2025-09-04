using Microsoft.EntityFrameworkCore;
using StudentsManagerApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagerApp.Infrastructure.DbContexts
{
    public class StudentsDbContext : DbContext
    {
        public StudentsDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Person> Persons { get; set; } = null!;
        public DbSet<Group> Groups { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;

    }
}
