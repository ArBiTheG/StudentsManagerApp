using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagerApp.Domain.Common
{
    /// <summary>
    /// Базовый класс модели <c>Сущность</c>
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// Идентификатор сущности
        /// </summary>
        [Key]
        public int Id { get; set; }
        protected Entity()
        {
            Id = 0;
        }
        protected Entity(Entity entity)
        {
            Id = entity.Id;
        }
    }
}
