using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagerApp.Domain.Common.Interfaces
{
    public interface IClonable<TEntity> where TEntity : Entity, new()
    {
        /// <summary>
        /// Клонирование объекта
        /// </summary>
        /// <param name="entity">Сущность объекта</param>
        /// <returns></returns>
        public TEntity Clone(TEntity entity);
    }
}
