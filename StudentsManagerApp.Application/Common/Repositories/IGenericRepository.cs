using StudentsManagerApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagerApp.Application.Common.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : Entity, new()
    {
        IEnumerable<TEntity> GetAll();
        TEntity? GetById(int id);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
