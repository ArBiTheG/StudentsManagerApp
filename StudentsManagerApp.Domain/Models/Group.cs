using StudentsManagerApp.Domain.Common;
using StudentsManagerApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagerApp.Domain.Models
{
    /// <summary>
    /// Класс модели <c>Группа</c>
    /// </summary>
    public class Group : Entity, ICloneable<Group>
    {
        /// <summary>
        /// Название группы
        /// </summary>
        [Required]
        [StringLength(32)]
        public string Name { get; set; }

        /// <summary>
        /// Описание группы
        /// </summary>
        [StringLength(65536)]
        public string Description { get; set; }

        public Group()
        {
            Name = string.Empty;
            Description = string.Empty;
        }

        public Group(Group group) : base(group)
        {
            Name = group.Name;
            Description = group.Description;
        }

        public Group Clone()
        {
            return new Group(this);
        }
    }
}
