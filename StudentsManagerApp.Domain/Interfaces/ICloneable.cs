using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagerApp.Domain.Interfaces
{
    public interface ICloneable<TEntity>
    {
        /// <summary>
        /// Клонирование объекта
        /// </summary>
        /// <param name="entity">Сущность объекта</param>
        /// <returns></returns>
        public TEntity Clone();
    }
}
