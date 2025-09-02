using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagerApp.Domain.Common
{
    public abstract class Entity
    {
        /// <summary>
        /// Идентификатор личности
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
